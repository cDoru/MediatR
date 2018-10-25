namespace MediatR.Queries
{
    public class ProductByIdQuery : IRequest<ProductByIdQueryResult>
    {
        public long Id { get; set; }
    }
}