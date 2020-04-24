using PodEZ.PodEZTemplate.Auditing;
using PodEZ.PodEZTemplate.Test.Base;
using Shouldly;
using Xunit;

namespace PodEZ.PodEZTemplate.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("PodEZ.PodEZTemplate.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("PodEZ.PodEZTemplate.Auditing.GenericEntityService`1[[PodEZ.PodEZTemplate.Storage.BinaryObject, PodEZ.PodEZTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("PodEZ.PodEZTemplate.Auditing.XEntityService`1[PodEZ.PodEZTemplate.Auditing.AService`5[[PodEZ.PodEZTemplate.Storage.BinaryObject, PodEZ.PodEZTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[PodEZ.PodEZTemplate.Storage.TestObject, PodEZ.PodEZTemplate.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
