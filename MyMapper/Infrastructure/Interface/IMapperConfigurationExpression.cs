using System.Collections.Generic;

namespace MyMapper.Infrastructure.Interface
{
    public interface IMapperConfigurationExpression : IProfileExpression
    {
        ICollection<IObjectMapper> Mappers { get; }
    }
}
