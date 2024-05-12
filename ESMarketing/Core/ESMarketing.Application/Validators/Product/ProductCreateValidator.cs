using ESMarketing.Application.ViewModels.Products;
using FluentValidation;

namespace ESMarketing.Application.Validators.Product;

public class ProductCreateValidator : AbstractValidator<ProductCreateModel>
{
    public ProductCreateValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
    }
}