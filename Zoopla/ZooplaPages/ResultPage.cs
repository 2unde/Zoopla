using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using Zoopla.ZoolaBaseClass;

namespace Zoopla.ZooplaPages
{
    
   public class ResultPage : Helper
    {

        private IWebElement listView;
        private IWebElement gridView;
        private IWebElement mapView;
        private IWebElement mapDetail;
        private IWebElement gridViewList;
        private IList<IWebElement> resultList;

        public void ThenSearchForToRentFlatDisplayed()
        {
            resultList = getElementsByCss(".listing-results-price.text-price");
            Assert.True(resultList.Count > 1);  
        }

        public void AndListViewIsActive()
        {
            listView = getElementByCss("[class='listing-view-link is-active']");
            Assert.True(listView.Enabled,"List view not enable");
        }

        public void AndIVerifyGridViewIsDisable()
        {
            gridView = getElementByClassName("listing-view-link");
            Assert.True(gridView.Displayed,"Grid view is disable");
        }

        public void AndIVeifymapViewIsDisable()
        {
            mapView = getElementByClassName("[class='listing-view-link.listing-view-link-last']");
            Assert.True(mapView.Displayed, "Map view is disable");

        }

        public void AndIClickAndValidateGridView()
        {
            gridView.Click();
            gridViewList =  getElementByCss("[class= 'listing-results.clearfix']");
            Assert.True(gridView.Displayed);
        } 

        //public void AndIClickAndValidateMapViewPageDisplay()
        //{
        //    mapView.Click();
        //    mapDetail = getElementById("maps-wrapper");
        //    Assert.True(mapDetail.Displayed, "Map page did not displayed");
        //}
    }
}
