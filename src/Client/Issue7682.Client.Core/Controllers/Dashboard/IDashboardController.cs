using Issue7682.Shared.Dtos.Dashboard;

namespace Issue7682.Client.Core.Controllers.Dashboard;

[Route("api/[controller]/[action]/")]
public interface IDashboardController : IAppController
{
    [HttpGet]
    Task<OverallAnalyticsStatsDataResponseDto> GetOverallAnalyticsStatsData(CancellationToken cancellationToken = default);

    [HttpGet]
    Task<List<ProductsCountPerCategoryResponseDto>> GetProductsCountPerCategoryStats(CancellationToken cancellationToken = default) => default!;

    [HttpGet]
    Task<List<ProductSaleStatResponseDto>> GetProductsSalesStats(CancellationToken cancellationToken = default) => default!;

    [HttpGet]
    Task<List<ProductPercentagePerCategoryResponseDto>> GetProductsPercentagePerCategoryStats(CancellationToken cancellationToken = default);
}
