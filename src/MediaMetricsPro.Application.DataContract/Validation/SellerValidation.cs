using FluentValidation;
using MediaMetricsPro.Application.DataContract.DataContract;
using MediaMetricsPro.Application.DataContract.Messages;

namespace MediaMetricsPro.Application.DataContract.Validation;

public class SellerValidation : AbstractValidator<SellerRequest>
    {
    public SellerValidation()
        {
        RuleFor(x => x.name)
            .NotNull().WithMessage(SellerMessages.NameIsNull)
            .NotEmpty().WithMessage(SellerMessages.NameIsEmpty);

        RuleFor(x => x.contact)
            .NotNull().WithMessage(SellerMessages.ContactIsNull)
            .NotEmpty().WithMessage(SellerMessages.ContactIsNull);
        }
    }
