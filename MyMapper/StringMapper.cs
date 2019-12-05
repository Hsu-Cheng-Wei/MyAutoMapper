using MyMapper.Extensions;
using MyMapper.Infrastructure.Interface;
using MyMapper.Infrastructure.Structure;
using System.Linq.Expressions;

namespace MyMapper
{
    public class StringMapper : IObjectMapper
    {
        public bool IsMach(TypePairs context) => context.SourceType == typeof(string) && context.DestinationType == typeof(string);

        public Expression MapExpression(IConfigurationProvider configurationProvider, ProfileMap profileMap, IMemberMap memberMap,
            Expression sourceExpression, Expression destExpression, Expression contextExpression)
        {
            return Expression.Call(sourceExpression, typeof(object).GetDeclaredMethod("ToString"));
        }
    }
}
