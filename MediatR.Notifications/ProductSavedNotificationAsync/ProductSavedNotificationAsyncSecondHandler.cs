using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Notifications
{
	public class ProductSavedNotificationAsyncSecondHandler : INotificationHandler<ProductSavedNotificationAsync>
	{
		public Task Handle(ProductSavedNotificationAsync notification, CancellationToken cancellationToken)
		{
			return Task.Run(() => Trace.WriteLine("ProductSavedNotificationAsyncSecondHandler.Handle(ProductSavedNotificationAsync)"));
		}
	}
}