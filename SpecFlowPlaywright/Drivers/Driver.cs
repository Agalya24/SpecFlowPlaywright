using System;
using Microsoft.Playwright;
using SpecFlowPlaywright.pages;

namespace SpecFlowPlaywright.Drivers
{
    public class Driver : IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;
        public Driver()
        {
            _page = InitiatePlaywrightDriver();
            HomePage = new HomePage(_page.Result);
            InstallationPage = new InstallationPage(_page.Result);
            NavigationPage = new NavigationPage(_page.Result);
        }

        public IPage Page => _page.Result;
        public HomePage HomePage { get; }
        public InstallationPage InstallationPage { get; }
        public NavigationPage NavigationPage { get; }
        private async Task<IPage> InitiatePlaywrightDriver()
        {
            //Playwright
             var playwright = await Playwright.CreateAsync().ConfigureAwait(false);
             _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
             {
                 Headless = false
             });
            return await _browser.NewPageAsync().ConfigureAwait(false);
        }

        public void Dispose() => _browser?.CloseAsync();
    }
}