using MyMapper.Infrastructure.Structure;
using System.Linq.Expressions;

namespace MyMapper.Infrastructure.Interface
{
    public interface IObjectMapper
    {
        bool IsMach(TypePairs context);

        Expression MapExpression(IConfigurationProvider configurationProvider, ProfileMap profileMap,
            IMemberMap memberMap, Expression sourceExpression, Expression destExpression, Expression contextExpression);
    }
}
