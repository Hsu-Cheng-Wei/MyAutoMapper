using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyMapper.Extensions
{
    public static class TypeExtension
    {
        public static MethodInfo GetDeclaredMethod(this Type type, string name) => type.GetAllMethods().SingleOrDefault(mi => mi.Name == name);

        public static IEnumerable<MethodInfo> GetAllMethods(this Type type) => type.GetRuntimeMethods();
    }
}
