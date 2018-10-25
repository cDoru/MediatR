using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Queries
{
	public class ProductByIdQueryAsyncHandler : IRequestHandler<ProductByIdQueryAsync, ProductByIdQueryAsyncResult>
	{
		public Task<ProductByIdQueryAsyncResult> Handle(ProductByIdQueryAsync request, CancellationToken cancellationToken)
		{
			Trace.WriteLine("ProductByIdQueryAsyncHandler.Handle(ProductByIdQueryAsync)");

			return Task.FromResult(new ProductByIdQueryAsyncResult { Id = request.Id, Description = $"Description {request.Id}" });
		}
	}
}