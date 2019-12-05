using MyMapper.Infrastructure.Structure;

namespace MyMapper
{
    public class TypeMap
    {
        public TypeDetails SourceTypeDetails { get; }

        public TypeDetails DestinationTypeDetails { get; }

        public TypePairs Types { get; }

        public ProfileMap Profile { get; }

        public TypeMap(TypeDetails sourceType, TypeDetails destinationType, ProfileMap profile)
        {
            SourceTypeDetails = sourceType;
            DestinationTypeDetails = destinationType;
            Types = new TypePairs(sourceType.Type, destinationType.Type);
            Profile = profile;
        }
    }
}
