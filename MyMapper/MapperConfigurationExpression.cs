using System.Collections.Generic;
using MyMapper.Infrastructure.Interface;

namespace MyMapper
{
    public class MapperConfigurationExpression : Profile, IMapperConfigurationExpression
    {
        private readonly IList<Profile> _profiles = new List<Profile>();
        public ICollection<IObjectMapper> Mappers => new List<IObjectMapper>()
        {
            new StringMapper()
        };
    }
}
