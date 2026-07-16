using System;
using AutoFixture.Xunit3;
using BrewLedger.Domain.Entities;
using BrewLedger.Domain.Enumerations;
using Xunit;

namespace Tests.UnitTests.Entities;

public class ProductTest
{
  [Theory]
  [AutoData]
  public void Product_RegisterChange_ShouldUpdateChangeDate(Product product)
  {
    var originalChangeDate = product.ChangeDate;
    var now = DateTime.UtcNow;

    product.RegisterChange();

    Assert.NotEqual(originalChangeDate, product.ChangeDate);
    Assert.True(product.ChangeDate >= now);
  }

  [Fact]
  public void Product_Activate_ShouldUpdateStatusTypeToActive()
  {
    var product = new Product { StatusType = StatusType.Deleted };

    product.Activate();

    Assert.Equal(StatusType.Activated, product.StatusType);
  }

  [Fact]
  public void Product_Deactivate_ShouldUpdateStatusTypeToDeactivated()
  {
    var product = new Product { StatusType = StatusType.Activated };

    product.Deactivate();

    Assert.Equal(StatusType.Deactivated, product.StatusType);
  }

  [Fact]
  public void Product_Delete_ShouldUpdateStatusTypeToDeleted()
  {
    var product = new Product { StatusType = StatusType.Activated };

    product.Delete();

    Assert.Equal(StatusType.Deleted, product.StatusType);
  }
}
