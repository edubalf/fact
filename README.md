# fact
Is a great tool to improve your stubs tests. Inspired in FFaker, a great Ruby test feature, Fact bring the same experiênce to C# developers

## Install
To install fact, run the following command in the Package Manager Console
```csharp
PM> Install-Package fact
```

## Fakers
discover all Fakers in Fact.Faker namespace

```csharp
  var customer = new Customer
  {
      Id = "build-test-01",
      Address = Faker.BR.AddressBR.Address,
      Email = Faker.Internet.Email("customer"),
      Name = Faker.Name.FullName,
      Site = Faker.Internet.HttpUri
  };
```

## Custom using Fakers
````csharp
using Fact.Factory;
using Fact.Tests.Domain.Model;

namespace Fact.Tests.Factory
{
    internal class CustomerFactory
    {
        public static void Build()
        {
            var customer = new Customer
            {
                Id = "build-test-01",
                Address = Faker.BR.AddressBR.Address,
                Email = Faker.Internet.Email("customer"),
                Name = Faker.Name.FullName,
                Site = Faker.Internet.HttpUri
            };

            var customer_without_email = new Customer
            {
                Id = "build-test-02",
                Address = Faker.BR.AddressBR.Address,
                Name = Faker.Name.FullName,
                Site = Faker.Internet.HttpUri
            };

            Builder.Current.Set(customer);
            Builder.Current.Set("without email", customer_without_email);
        }
    }
}
````


##Setup 
````csharp
namespace Fact.Tests
{
    [SetUpFixture]
    internal class FactInitializer
    {
        [SetUp]
        public void Before()
        {
            CustomerFactory.Build();
        }

        [TearDown]
        public void Down()
        {
            Builder.Current.Clear();
        }
    }
}
````

## Using
````csharp
using Fact.Factory;

namespace Fact.Tests.Unity.Domain.Model
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void BuildDeCustumer()
        {
            var customer = Builder.Current.Build<Customer>();
            var customerWithoutEmail = Builder.Current.Build<Customer>("without email");
            
            Assert.AreEqual("build-test-01", customer.Id);
            Assert.AreEqual("build-test-02", customerWithoutEmail.Id);
        }
    }
}
````

