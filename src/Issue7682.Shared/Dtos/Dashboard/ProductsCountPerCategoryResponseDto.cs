﻿namespace Issue7682.Shared.Dtos.Dashboard;

public class ProductsCountPerCategoryResponseDto
{
    public string? CategoryName { get; set; }

    public string? CategoryColor { get; set; }

    public int ProductCount { get; set; }
}
