namespace MediatR.Notifications
{
    public class ProductSavedNotification : INotification
    {
        public long Id { get; set; }
    }
}