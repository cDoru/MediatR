using System.Diagnostics;

namespace MediatR.Notifications
{
	public class ProductSavedNotificationFirstHandler : NotificationHandler<ProductSavedNotification>
	{
		protected override void Handle(ProductSavedNotification notification)
		{
			Trace.WriteLine("ProductSavedNotificationFirstHandler.Handle(ProductSavedNotification)");
		}
	}
}