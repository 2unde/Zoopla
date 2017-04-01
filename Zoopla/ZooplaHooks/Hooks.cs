using TechTalk.SpecFlow;
using Zoopla.ZoolaBaseClass;

namespace Zoopla.ZooplaHooks
{
    public sealed class Hooks : Helper
    {
        [BeforeScenario]

        public void BeforeScenario()
        {
            launchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            closeBrowser();
        }
    }
}
