using System;

namespace MyMapper.Common
{
    public class TypeMapFactory
    {
        public static TypeMap CreateTypeMap(Type sourceType, Type destinationType, ProfileMap options)
        {
            var sourceInfo = new TypeDetails(sourceType, options);
            var destinationInfo = new TypeDetails(destinationType, options);
            return new TypeMap(sourceInfo, destinationInfo, options);
        }
    }
}
