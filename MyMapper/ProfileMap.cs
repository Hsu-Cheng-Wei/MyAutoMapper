using MyMapper.Common;
using MyMapper.Infrastructure.Interface;
using MyMapper.Infrastructure.Structure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMapper
{
    public class ProfileMap
    {
        private readonly IEnumerable<ITypeMapConfiguration> _typeMapConfigs;

        private LockingConcurrentDictionary<Type, TypeDetails> _typeDetails;
        public ProfileMap(IProfileConfiguration profile, IConfiguration configuration)
        {
            _typeDetails = new LockingConcurrentDictionary<Type, TypeDetails>(t => new TypeDetails(t, this));
            _typeMapConfigs = profile.TypeMapConfigs.ToArray();
        }

        public void Register(IConfigurationProvider configurationProvider)
        {
            foreach (var config in _typeMapConfigs)
            {
                var typeMap = TypeMapFactory.CreateTypeMap(config.SourceType, config.DestinationType, this);
                configurationProvider.RegisterTypeMap(typeMap);
            }
        }
    }
}
