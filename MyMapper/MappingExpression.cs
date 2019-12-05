using MyMapper.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMapper
{
    public class MappingExpression<TSource, TDestination> :
        MappingExpressionBase<object, object, IMappingExpression>, IMappingExpression
    {
        public MappingExpression() : base(typeof(TSource), typeof(TDestination)){}
    }
}
