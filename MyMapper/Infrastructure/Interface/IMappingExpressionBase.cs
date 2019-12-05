namespace MyMapper.Infrastructure.Interface
{
    public interface IMappingExpressionBase<TSource, TDestination, out TMappingExpression>
        where TMappingExpression : IMappingExpressionBase<TSource, TDestination, TMappingExpression>
    {

    }
}
