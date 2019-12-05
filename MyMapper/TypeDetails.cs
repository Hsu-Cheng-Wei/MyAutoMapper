using System;

namespace MyMapper
{
    public class TypeDetails
    {
        public Type Type { get; }

        public TypeDetails(Type type, ProfileMap profile)
        {
            Type = type;
        }
    }
}
