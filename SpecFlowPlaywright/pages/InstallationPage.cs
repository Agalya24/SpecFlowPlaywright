using Microsoft.Playwright;

namespace SpecFlowPlaywright.pages
{
    public class InstallationPage
    {
        private readonly IPage _page;
        public readonly ILocator _heading;
        public InstallationPage(IPage page)
        {
            _page = page;
            _heading = _page.GetByText("Installation");
        }

        public async Task<bool> IsExistsInstallationHeading()
        {
            await _page.WaitForSelectorAsync("//*[@id=\"__docusaurus_skipToContent_fallback\"]//main//header/h1");
            return await _heading.First.IsVisibleAsync();
        }

        
    }
}