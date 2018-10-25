# MediatR

CQRS with MediatR in .NET Core.

## Command

 ```csharp
public class ProductSaveCommand : IRequest
{
    public long Id { get; set; }

    public string Description { get; set; }
}
 ```

## CommandHandler

```csharp
public class ProductSaveCommandHandler : RequestHandler<ProductSaveCommand>
{
    protected override void Handle(ProductSaveCommand request)
    {
        Trace.WriteLine("ProductSaveCommandHandler.Handle(ProductSaveCommand)");
    }
}
```

## Query

```csharp
public class ProductByIdQuery : IRequest<ProductByIdQueryResult>
{
    public long Id { get; set; }
}
```

## QueryHandler

```csharp
public class ProductByIdQueryHandler : RequestHandler<ProductByIdQuery, ProductByIdQueryResult>
{
    protected override ProductByIdQueryResult Handle(ProductByIdQuery request)
    {
        Trace.WriteLine("ProductByIdQueryHandler.Handle(ProductByIdQuery)");

        return new ProductByIdQueryResult { Id = request.Id, Description = $"Description {request.Id}" };
    }
}
```

## Notification

```csharp
public class ProductSavedNotification : INotification
{
    public long Id { get; set; }
}
```

## NotificationHandler

```csharp
public class ProductSavedNotificationFirstHandler : NotificationHandler<ProductSavedNotification>
{
    protected override void Handle(ProductSavedNotification notification)
    {
        Trace.WriteLine("ProductSavedNotificationFirstHandler.Handle(ProductSavedNotification)");
    }
}
```

```csharp
public class ProductSavedNotificationSecondHandler : NotificationHandler<ProductSavedNotification>
{
    protected override void Handle(ProductSavedNotification notification)
    {
        Trace.WriteLine("ProductSavedNotificationSecondHandler.Handle(ProductSavedNotification)");
    }
}
```

## Tests

```csharp
[TestClass]
public class Tests
{
    private readonly IMediator _mediator;

    public Tests()
    {
        var services = new ServiceCollection();
        services.AddMediatR(Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(Assembly.Load));
        _mediator = services.BuildServiceProvider().GetService<IMediator>();
    }

    [TestMethod]
    public void ProductByIdQuery()
    {
        var result = _mediator.Send(new ProductByIdQuery { Id = 1 });
        Assert.IsTrue(result.Result.Id == 1);
    }

    [TestMethod]
    public void ProductByIdQueryAsync()
    {
        var result = _mediator.Send(new ProductByIdQueryAsync { Id = 1 });
        Assert.IsTrue(result.Result.Id == 1);
    }

    [TestMethod]
    public void ProductSaveCommand()
    {
        _mediator.Send(new ProductSaveCommand { Id = 1, Description = "Description 1" });
    }

    [TestMethod]
    public void ProductSaveCommandAsync()
    {
        _mediator.Send(new ProductSaveCommandAsync { Id = 1, Description = "Description 1" });
    }

    [TestMethod]
    public void ProductSavedNotification()
    {
        _mediator.Publish(new ProductSavedNotification());
    }

    [TestMethod]
    public void ProductSavedNotificationAsync()
    {
        _mediator.Publish(new ProductSavedNotificationAsync());
    }
}
```
