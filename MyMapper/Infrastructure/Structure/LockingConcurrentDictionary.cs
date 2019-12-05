using System;
using System.Collections.Concurrent;

namespace MyMapper.Infrastructure.Structure
{
    public struct LockingConcurrentDictionary<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> _dictionary;
        private readonly Func<TKey, Lazy<TValue>> _valueFactory;

        public LockingConcurrentDictionary(Func<TKey, TValue> valueFunc)
        {
            _dictionary = new ConcurrentDictionary<TKey, Lazy<TValue>>();
            _valueFactory = key => new Lazy<TValue>(() => valueFunc(key));
        }

        public TValue GetOrAdd(TKey key) => _dictionary.GetOrAdd(key, _valueFactory).Value;
    }
}
