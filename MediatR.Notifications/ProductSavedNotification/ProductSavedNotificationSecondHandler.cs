using System.Diagnostics;

namespace MediatR.Notifications
{
	public class ProductSavedNotificationSecondHandler : NotificationHandler<ProductSavedNotification>
	{
		protected override void Handle(ProductSavedNotification notification)
		{
			Trace.WriteLine("ProductSavedNotificationSecondHandler.Handle(ProductSavedNotification)");
		}
	}
}