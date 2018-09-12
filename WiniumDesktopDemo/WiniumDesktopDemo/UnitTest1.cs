using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;

namespace WiniumDesktopDemo
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Target Application Path
        /// </summary>
        private const string TargetAppPath = @"C:\Windows\System32\calc.exe";
        /// <summary>
        /// Winium.Desktop.Driver.exe Path
        /// </summary>
        private const string WiniumDriverPath = @"C:\Winium.Desktop.Driver";
        /// <summary>
        /// WiniumDriver Object
        /// </summary>
        private WiniumDriver driver;
        /// <summary>
        /// ScreenShot Object
        /// </summary>
        private Screenshot ss;

        #region Controls
        private IWebElement window;
        private IWebElement key0;
        private IWebElement key1;
        private IWebElement key2;
        private IWebElement key3;
        private IWebElement key4;
        private IWebElement key5;
        private IWebElement key6;
        private IWebElement key7;
        private IWebElement key8;
        private IWebElement key9;
        private IWebElement keyAdd;
        private IWebElement keyEqual;
        #endregion

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new DesktopOptions();
            options.ApplicationPath = TargetAppPath;
            driver = new WiniumDriver(WiniumDriverPath, options);

            window = driver.FindElementByClassName("CalcFrame");
            key0 = window.FindElement(By.Name("0"));
            key1 = window.FindElement(By.Name("1"));
            key2 = window.FindElement(By.Name("2"));
            key3 = window.FindElement(By.Name("3"));
            key4 = window.FindElement(By.Name("4"));
            key5 = window.FindElement(By.Name("5"));
            key6 = window.FindElement(By.Name("6"));
            key7 = window.FindElement(By.Name("7"));
            key8 = window.FindElement(By.Name("8"));
            key9 = window.FindElement(By.Name("9"));
            keyAdd = window.FindElement(By.Name("加算"));
            keyEqual = window.FindElement(By.Name("等号"));
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Close();
            driver.Dispose();
        }

        /// <summary>
        /// テストメソッド1
        /// 数字キーを0から9まで押下した合計値をテストする
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            // operation
            key0.Click();
            keyAdd.Click();
            key1.Click();
            keyAdd.Click();
            key2.Click();
            keyAdd.Click();
            key3.Click();
            keyAdd.Click();
            key4.Click();
            keyAdd.Click();
            key5.Click();
            keyAdd.Click();
            key6.Click();
            keyAdd.Click();
            key7.Click();
            keyAdd.Click();
            key8.Click();
            keyAdd.Click();
            key9.Click();
            keyEqual.Click();

            // screenshot
            SaveScreenShot("TestMethod1");

            // assert
            Assert.IsTrue(true);
        }

        /// <summary>
        /// テストメソッド2
        /// 数字キーを0から9までの奇数キー押下の合計値をテストする
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            // operation
            key1.Click();
            keyAdd.Click();
            key3.Click();
            keyAdd.Click();
            key5.Click();
            keyAdd.Click();
            key7.Click();
            keyAdd.Click();
            key9.Click();
            keyEqual.Click();

            // screenshot
            SaveScreenShot("TestMethod2");

            // assert
            Assert.IsTrue(true);
        }

        /// <summary>
        /// スクリーンショット処理
        /// </summary>
        /// <param name="fileName"></param>
        private void SaveScreenShot(string fileName)
        {
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            var file = System.IO.Path.Combine(
                System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                fileName + ".png"
                );
            ss.SaveAsFile(file, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
