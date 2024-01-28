

using Microsoft.Playwright;

namespace SpecFlowPlaywright.pages;
 public class HomePage
{
    private readonly IPage _page;
    private readonly ILocator _heading;
    private readonly ILocator _getStartedLink;
   public HomePage(IPage page)
    {
        _page = page;
        _heading = _page.Locator(selector: "text='Playwright'");
        _getStartedLink = _page.Locator(selector:"text='Get started'");
    }

    public async Task ClickGetStarted() => await _getStartedLink.ClickAsync();
    public async Task<bool> IsHeadingExists() => await _heading.First.IsVisibleAsync();

}