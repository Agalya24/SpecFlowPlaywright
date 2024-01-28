using Microsoft.Playwright;

namespace SpecFlowPlaywright.pages
{
    public class NavigationPage
    {
        private readonly IPage _page;
        public NavigationPage(IPage page){
            _page = page;
        }
        public async Task NavigateToInstallationPage(){
            HomePage homePage = new(_page);
           await homePage.ClickGetStarted();
        }
    }
}