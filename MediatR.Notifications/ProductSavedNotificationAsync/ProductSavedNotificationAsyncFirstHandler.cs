using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Notifications
{
	public class ProductSavedNotificationAsyncFirstHandler : INotificationHandler<ProductSavedNotificationAsync>
	{
		public Task Handle(ProductSavedNotificationAsync notification, CancellationToken cancellationToken)
		{
			return Task.Run(() => Trace.WriteLine("ProductSavedNotificationAsyncFirstHandler.Handle(ProductSavedNotificationAsync)"));
		}
	}
}