using MyMapper.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMapper.Infrastructure.Structure
{
    public struct MapRequest : IEquatable<MapRequest>
    {
        public TypePairs RequestType { get; }

        public TypePairs RuntimeType { get; }

        public IMemberMap MemberMap { get; }

        public bool Equals(MapRequest other) => true;
            //RequestType == other.RequestType && RuntimeType == other.RuntimeType
            //&& MemberMap.GetHashCode() == other.MemberMap.GetHashCode();
    }
}
