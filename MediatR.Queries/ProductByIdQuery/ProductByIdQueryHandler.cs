using System.Diagnostics;

namespace MediatR.Queries
{
	public class ProductByIdQueryHandler : RequestHandler<ProductByIdQuery, ProductByIdQueryResult>
	{
		protected override ProductByIdQueryResult Handle(ProductByIdQuery request)
		{
			Trace.WriteLine("ProductByIdQueryHandler.Handle(ProductByIdQuery)");

			return new ProductByIdQueryResult { Id = request.Id, Description = $"Description {request.Id}" };
		}
	}
}