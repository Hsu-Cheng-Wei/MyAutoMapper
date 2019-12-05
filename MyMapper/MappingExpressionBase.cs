using MyMapper.Infrastructure.Interface;
using MyMapper.Infrastructure.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMapper
{
    public class MappingExpressionBase : ITypeMapConfiguration
    {
        public MappingExpressionBase(Type sourceType, Type destinationType)
        {
            TypePairs = new TypePairs(sourceType, destinationType);
        }
        public Type SourceType => TypePairs.SourceType;

        public Type DestinationType => TypePairs.DestinationType;

        public bool IsOpenGeneric => throw new NotImplementedException();

        public TypePairs TypePairs { get; }

        public ITypeMapConfiguration ReverseTypeMap => throw new NotImplementedException();

        public void Configure(TypeMap typeMap)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class MappingExpressionBase<TSource, TDestination, TMappingExpression> :
        MappingExpressionBase, IMappingExpressionBase<TSource, TDestination, TMappingExpression>
        where TMappingExpression : class, IMappingExpressionBase<TSource, TDestination, TMappingExpression>
    {
        public MappingExpressionBase() : base(typeof(TSource), typeof(TDestination)) { }

        public MappingExpressionBase(Type source, Type destination) : base(source, destination) { }
    }
}
