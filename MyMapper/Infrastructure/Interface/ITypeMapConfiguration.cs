using MyMapper.Infrastructure.Structure;
using System;

namespace MyMapper.Infrastructure.Interface
{
    public interface ITypeMapConfiguration
    {
        void Configure(TypeMap typeMap);
        Type SourceType { get; }
        Type DestinationType { get; }
        bool IsOpenGeneric { get; }
        TypePairs TypePairs { get; }
        ITypeMapConfiguration ReverseTypeMap { get; }
    }
}
