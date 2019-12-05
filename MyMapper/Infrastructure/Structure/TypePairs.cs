using System;

namespace MyMapper.Infrastructure.Structure
{
    public struct TypePairs : IEquatable<TypePairs>
    {
        public Type SourceType { get; set; }

        public Type DestinationType { get; set; }

        public TypePairs(Type source, Type destination)
        {
            SourceType = source;
            DestinationType = destination;
        }

        public static TypePairs Create<TSource, TDestination>(TSource source, TDestination destination) =>
            new TypePairs(source.GetType(), destination.GetType());

        public static TypePairs Create(Type source, Type destination) =>
            new TypePairs(source, destination);

        public bool Equals(TypePairs pairs) =>
            pairs.SourceType == SourceType && pairs.DestinationType == DestinationType;

    }
}
