using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using MediatR.Commands;
using MediatR.Notifications;
using MediatR.Queries;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatR.Tests
{
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
}