﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace SalesForce.Pages
{
    public class OrganisationNewPage: BasePage
    {
        public OrganisationNewPage(IWebDriver Driver) : base(Driver) { }

        //private By _btnContinue = By.Name("save");
        private By _btnContinue = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        //private By _btnCancel = By.Name("cancel");
        private By _btnCancel = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _lstRecordType = By.XPath("//*[@id='p3']");

        public IWebElement ContinueButton
        {
            get
            {
                return driver.FindElement(_btnContinue);
            }
        }
        public IWebElement CancelButton
        {
            get
            {
                return driver.FindElement(_btnCancel);
            }
        }

        

        public IWebElement RecordTypeList
        {
            get
            {
                return driver.FindElement(_lstRecordType);
            }
        }
        //public void SelectNewOrganisationRecordType(string orgasationType)
        //{
        //    GetDisplayedElement(_lstRecordType, 500, 15000).SendKeys(orgasationType);
        //}
        public void SelectOrganisationType(string organisationType)
        {
            if (RecordTypeList.Displayed)
            {
                RecordTypeList.Click();
                var x2 = organisationType;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                IWebElement hiddenLink = driver.FindElement(By.XPath(x1 + x2 + x3));
                String script = "arguments[0].click();";
                js.ExecuteScript(script, hiddenLink);
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("organisation type could not be selected");
            }
        }

        /*
         * //-------------------------------------------------------------------------------------------------------
            //Handle Hidden objects
            //-------------------------------------------------------------------------------------------------------
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement hiddenLink = driver.FindElement(By.XPath("//*[@id='ManageUsers_font']"));
            String script = "arguments[0].click();";
            js.ExecuteScript(script, hiddenLink);
            //-------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------

        */
        public void VerifyPage()
        {
            Assert.AreEqual("New Organisation: Select Organisation Record Type ~ Salesforce - Enterprise Edition", driver.Title);
            Assert.IsTrue(RecordTypeList.Displayed);
        }

        public void ClickOnContinueButton()
        {
            if (ContinueButton.Displayed)
            {
                ContinueButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnCancelButton()
        {
            if (CancelButton.Displayed)
            {
                CancelButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
    }
}
