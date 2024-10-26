using FluentAssertions;
using MediaMetricsPro.Application.DataContract.DataContract.Request;
using MediaMetricsPro.Application.DataContract.Messages;
using MediaMetricsPro.Application.DataContract.Validation;

namespace MediaMetricsPro.UnitTest.DataContract.Validations;

public class SellerValidatorTest
{
    [Theory(DisplayName = "Testing Seller Name")]
    [InlineData(null, "xx", "name", SellerMessages.NameIsNull)]
    [InlineData("", "xx", "name", SellerMessages.NameIsEmpty)]
    [InlineData(" ", "xx", "name", SellerMessages.NameIsEmpty)]
    public void SellerName_Should_Be_Invalid(string name, string contact, string propertyName, string messageError)
    {
        var seller = new SellerRequest(name, contact);
        var validator = new SellerValidation();

        var result = validator.Validate(seller);

        Assert.False(result.IsValid);
        result
            .Errors
            .First(x => x.PropertyName == propertyName &&
                     name == x.FormattedMessagePlaceholderValues["PropertyValue"])
            .ErrorMessage
            .Should()
            .Be(messageError);
    }

    [Theory(DisplayName = "Testing Seller Contact")]
    [InlineData("xx", null, "contact", SellerMessages.ContactIsNull)]
    [InlineData("xx", "", "contact", SellerMessages.ContactIsEmpty)]
    [InlineData("xx", " ", "contact", SellerMessages.ContactIsEmpty)]
    public void SellerContact_Should_Be_Invalid(string name, string contact, string propertyName, string messageError)
    {
        var seller = new SellerRequest(name, contact);
        var validator = new SellerValidation();

        var result = validator.Validate(seller);

        Assert.False(result.IsValid);
        result
            .Errors
            .First(x => x.PropertyName == propertyName &&
                    contact == x.FormattedMessagePlaceholderValues["PropertyValue"])
            .ErrorMessage
            .Should()
            .Be(messageError);
    }
}