using System;

namespace MyMapper.Infrastructure.Interface
{
    public interface IProfileExpression
    {
        IMappingExpression CreateMapper(Type sourceType, Type destinationType);

        IMappingExpression CreateMapper<TSource, TDestination>();
    }
}
