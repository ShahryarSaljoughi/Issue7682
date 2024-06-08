﻿using Issue7682.Client.Core.Controllers.Categories;
using Issue7682.Client.Core.Controllers.Product;
using Issue7682.Shared.Dtos.Products;

namespace Issue7682.Client.Core.Components.Pages.Products;

public partial class AddOrEditProductModal
{
    [AutoInject] ICategoryController categoryController = default!;
    [AutoInject] IProductController productController = default!;

    private bool isOpen;
    private bool isLoading;
    private bool isSaving;
    private ProductDto product = new();
    private List<BitDropdownItem<string>> allCategoryList = [];
    private string selectedCategoyId = string.Empty;

    [Parameter] public EventCallback OnSave { get; set; }

    protected override async Task OnInitAsync()
    {
        await LoadAllCategoriesAsync();
    }

    public async Task ShowModal(ProductDto productToShow)
    {
        await InvokeAsync(() =>
        {
            isOpen = true;
            product = productToShow;
            selectedCategoyId = (product.CategoryId ?? 0).ToString();

            StateHasChanged();
        });
    }

    private async Task LoadAllCategoriesAsync()
    {
        isLoading = true;

        try
        {
            var categoryList = await categoryController.Get(CurrentCancellationToken);

            allCategoryList = categoryList.Select(c => new BitDropdownItem<string>()
            {
                ItemType = BitDropdownItemType.Normal,
                Text = c.Name ?? string.Empty,
                Value = c.Id.ToString()
            }).ToList();
        }
        finally
        {
            isLoading = false;
        }
    }

    private async Task Save()
    {
        if (isLoading) return;

        isSaving = true;

        try
        {
            if (product.Id == 0)
            {
                await productController.Create(product, CurrentCancellationToken);
            }
            else
            {
                await productController.Update(product, CurrentCancellationToken);
            }

            isOpen = false;
        }
        finally
        {
            isSaving = false;

            await OnSave.InvokeAsync();
        }
    }

    private async Task OnCloseClick()
    {
        isOpen = false;
    }
}
