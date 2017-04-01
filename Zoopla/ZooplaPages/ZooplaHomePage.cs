using OpenQA.Selenium;
using Zoopla.ZoolaBaseClass;
using NUnit.Framework;

namespace Zoopla.ZooplaPages
{
    
    public class ZooplaHomePage : Helper
    {
        private readonly string baseUrl = "http://www.zoopla.co.uk/";

        private IWebElement logo;
        private IWebElement toRent;
        private IWebElement searchField;
        private IWebElement minPrice;
        private IWebElement maxPrice;
        private IWebElement propertyType;
        private IWebElement searchButton;

        public void GivenINavigateToZooplaHomePage()
        {
            launchUrl(baseUrl);
        }
        public void AndIAmOnZooplaHomePage()
        {
            logo = getElementByClassName("icon--logo");
            Assert.True(logo.Displayed);
        
        }

        public void AndIClickOnToRent()
        {
            toRent = getElementById("search-tabs-to-rent");
            toRent.Click();
           
        }

        public void WhenIEnterLocationIntoTheSearchField()
        {
            searchField = getElementById("search-input-location");
            searchField.SendKeys("Portsmouth");
        }

        public void AndISelectMinimumPrice()
        {
            minPrice = getElementById("rent_price_min_per_month");
            selectByVisibleText(minPrice,"500");
            
        }

        public void AndISelectMaximumPrice()
        {
            maxPrice = getElementById("rent_price_max_per_month");
            selectByVisibleText(maxPrice,"2000");
        }

        public void AndISelectPropertyType()
        {
            propertyType = getElementById("property_type");
            selectByVisibleText(propertyType, "Flats");
        }

        public ResultPage AndIClickOnSearchButton()
        {
            searchButton = getElementById("search - submit");
            searchButton.Click();

            return new ResultPage();
        }

        
    }


}
