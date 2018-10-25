namespace MediatR.Commands
{
    public class ProductSaveCommand : IRequest
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}