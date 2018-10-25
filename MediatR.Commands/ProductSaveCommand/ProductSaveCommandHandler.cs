using System.Diagnostics;

namespace MediatR.Commands
{
	public class ProductSaveCommandHandler : RequestHandler<ProductSaveCommand>
	{
		protected override void Handle(ProductSaveCommand request)
		{
			Trace.WriteLine("ProductSaveCommandHandler.Handle(ProductSaveCommand)");
		}
	}
}