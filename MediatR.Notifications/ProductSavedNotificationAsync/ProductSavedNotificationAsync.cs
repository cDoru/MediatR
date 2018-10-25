namespace MediatR.Notifications
{
    public class ProductSavedNotificationAsync : INotification
    {
        public long Id { get; set; }
    }
}