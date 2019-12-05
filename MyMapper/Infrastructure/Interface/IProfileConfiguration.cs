using System;
using System.Collections.Generic;
using System.Text;

namespace MyMapper.Infrastructure.Interface
{
    public interface IProfileConfiguration
    {
        IEnumerable<IMemberConfiguration> MemberConfigures { get; }

        IEnumerable<ITypeMapConfiguration> TypeMapConfigs { get; }
    }
}
