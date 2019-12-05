using System;
using System.Collections.Generic;

namespace MyMapper.Infrastructure.Interface
{
    public interface IMemberConfiguration
    {
        IList<IChildMemberConfiguration> MemberMappers { get; }
        IMemberConfiguration AddMember<TMemberMapper>(Action<TMemberMapper> setupAction = null)
            where TMemberMapper : IChildMemberConfiguration, new();
    }
}