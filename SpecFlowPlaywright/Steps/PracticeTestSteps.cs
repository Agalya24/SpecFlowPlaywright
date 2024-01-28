using FluentAssertions;
using NUnit.Framework;
using SpecFlowPlaywright.Drivers;

namespace SpecFlowPlaywright.Steps;

[Binding]
public sealed class PracticeTestSteps
{
    private readonly Driver _driver;
    public PracticeTestSteps(Driver driver)
    {
        _driver = driver;
    }


    [Then(@"I should see Installation Page")]
    public async Task ThenIShouldSeeInstallationPage()
    {
        var isExist = await _driver.InstallationPage.IsExistsInstallationHeading();
        isExist.Should().Be(true);
    }

    [Given(@"I want to access Installation Page")]
    public async Task GivenIWantToAccessInstallationPage()
    {
        await _driver.NavigationPage.NavigateToInstallationPage();

    }

    [Given(@"I launch the application")]
    public async Task GivenILaunchTheApplication()
    {
        await _driver.Page.GotoAsync("https://playwright.dev");
    }
}