using MyMapper.Infrastructure.Interface;
using MyMapper.Infrastructure.Structure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMapper
{
    public class MapperConfiguration : Profile, IConfigurationProvider
    {
        public IEnumerable<ProfileMap> Profiles { get; }

        private readonly IEnumerable<IObjectMapper> _mappers;

        private readonly Dictionary<TypePairs, TypeMap> _typeMapRegistry = new Dictionary<TypePairs, TypeMap>();

        private ProfileMap Configuration { get; }

        public MapperConfiguration(Action<IMapperConfigurationExpression> configure)
        {
            var expr = new MapperConfigurationExpression();
            configure(expr);
            _mappers = expr.Mappers.ToArray();
            Configuration = new ProfileMap(expr, null);
            Profiles = new[] { Configuration };

            foreach (var profile in Profiles)
                profile.Register(this);
        }

        public void RegisterTypeMap(TypeMap typeMap) => _typeMapRegistry[typeMap.Types] = typeMap;

        public TypeMap FindTypeMapFor<TSource, TDestination>()
        {
            TypeMap result; 
            _typeMapRegistry.TryGetValue(new TypePairs(typeof(TSource), typeof(TDestination)), out result);
            return result;
        }
           
    }
}
