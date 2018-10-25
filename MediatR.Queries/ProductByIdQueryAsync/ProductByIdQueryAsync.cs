namespace MediatR.Queries
{
    public class ProductByIdQueryAsync : IRequest<ProductByIdQueryAsyncResult>
    {
        public long Id { get; set; }
    }
}