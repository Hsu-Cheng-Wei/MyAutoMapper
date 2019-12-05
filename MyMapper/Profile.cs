using System;
using System.Collections.Generic;
using MyMapper.Infrastructure.Interface;

namespace MyMapper
{
    public class Profile : IProfileExpression, IProfileConfiguration
    {
        public IEnumerable<ITypeMapConfiguration> TypeMapConfigs => _typeMapConfigs;

        private readonly List<ITypeMapConfiguration> _typeMapConfigs = new List<ITypeMapConfiguration>();

        public virtual string ProfileName { get; }

        protected Profile()
        {
            ProfileName = GetType().FullName;
        }
        private readonly IEnumerable<IMemberConfiguration> _memberConfigures = new List<IMemberConfiguration>();

        IEnumerable<IMemberConfiguration> IProfileConfiguration.MemberConfigures => _memberConfigures;

        public IMappingExpression CreateMapper(Type sourceType, Type destinationType)
        {
            throw new NotImplementedException();
        }

        public IMappingExpression CreateMapper<TSource, TDestination>()
        {
            var mappingExp = new MappingExpression<TSource, TDestination>();

            _typeMapConfigs.Add(mappingExp);

            return mappingExp;
        }
    }
}