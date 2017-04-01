using TechTalk.SpecFlow;
using Zoopla.ZoolaBaseClass;
using Zoopla.ZooplaPages;

namespace Zoopla.Steps
{
    [Binding]
    public sealed class ZooplaSearchSteps : Helper
    {
        ZooplaHomePage homepage = new ZooplaHomePage();
        ResultPage result = new ResultPage();


        [Given(@"I navigate to Zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            homepage.GivenINavigateToZooplaHomePage();
            
        }

        [Given(@"Zoopla logo is displayed")]
        public void GivenZooplaLogoIsDisplayed()
        {
            homepage.AndIAmOnZooplaHomePage();
        }

        [Given(@"I click To rent button")]
        public void GivenIClickToRentButton()
        {
            homepage.AndIClickOnToRent();
        }

        [When(@"I enter my desire destion in the search field")]
        public void WhenIEnterMyDesireDestionInTheSearchField()
        {
            homepage.WhenIEnterLocationIntoTheSearchField();
        }

        [When(@"I select minimum price")]
        public void WhenISelectMinimumPrice()
        {
            homepage.AndISelectMinimumPrice();
        }

        [When(@"I select maximum price from the dropdown")]
        public void WhenISelectMaximumPriceFromTheDropdown()
        {
            homepage.AndISelectMaximumPrice();
        }

        [When(@"I select property type from the dropdown")]
        public void WhenISelectPropertyTypeFromTheDropdown()
        {
            homepage.AndISelectPropertyType();
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            result = homepage.AndIClickOnSearchButton();
        }

        [Then(@"the result of the search to rent flat is displayed")]
        public void ThenTheResultOfTheSearchToRentFlatIsDisplayed()
        {
            result.ThenSearchForToRentFlatDisplayed();
        }

        [Then(@"List view is enable")]
        public void ThenListViewIsEnable()
        {
            result.AndListViewIsActive();
        }

        [Then(@"Grid view on result page is disable")]
        public void ThenGridViewOnResultPageIsDisable()
        {
            result.AndIVerifyGridViewIsDisable();
        }

        [Then(@"Map view is on result page is disable")]
        public void ThenMapViewIsOnResultPageIsDisable()
        {
            result.AndIVeifymapViewIsDisable();
        }

        [Then(@"I Click and validate Grid view")]
        public void ThenIClickAndValidateGridView()
        {
            result.AndIClickAndValidateGridView();
            
        }

        //[Then(@"I click and validate Map view")]
        //public void ThenIClickAndValidateMapView()
        //{
        //    result.AndIClickAndValidateMapViewPageDisplay();
        //}


    }
}
