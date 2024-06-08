﻿using Microsoft.AspNetCore.Components.WebAssembly.Services;

namespace Issue7682.Client.Core.Components.Pages.Dashboard;

[Authorize]
public partial class DashboardPage
{
    [AutoInject] LazyAssemblyLoader lazyAssemblyLoader = default!;

    private bool isLoadingAssemblies = true;

    protected async override Task OnInitAsync()
    {
        try
        {
            if (OperatingSystem.IsBrowser())
            {
                await lazyAssemblyLoader.LoadAssembliesAsync(["Newtonsoft.Json.wasm"]);
            }
        }
        finally
        {
            isLoadingAssemblies = false;
        }

        await base.OnInitAsync();
    }
}
