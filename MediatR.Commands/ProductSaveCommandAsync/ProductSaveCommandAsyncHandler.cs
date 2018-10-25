using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Commands
{
	public class ProductSaveCommandAsyncHandler : AsyncRequestHandler<ProductSaveCommandAsync>
	{
		protected override Task Handle(ProductSaveCommandAsync request, CancellationToken cancellationToken)
		{
			return Task.Run(() => Trace.WriteLine("ProductSaveCommandAsyncHandler.Handle(ProductSaveCommandAsync)"));
		}
	}
}