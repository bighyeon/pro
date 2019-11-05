using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;

namespace WindowsFormsApp1.Css
{
    class RandomUrl
    {
        Random random = new Random();
        
        private string path;
        private string[] txtdata;
        private int data;
        private int num;
        private int Querynum;
        private IWebDriver driver;
        

        //Driver Path
        private String Chrome_Driver_Path;

        public RandomUrl()
        {
            path = @"C:\Users\wkdlf\Desktop\ㅅㅅ.txt";
            txtdata = System.IO.File.ReadAllLines(path);
            data = txtdata.Length;

            num = random.Next(0, 4);
            Querynum = random.Next(data);
            Chrome_Driver_Path = Application.StartupPath + @"\driver\";

            System.Diagnostics.Debug.WriteLine(Chrome_Driver_Path);
        }

        public void XpathGet(string xpath)
        {
      
            xpath = string.Format("{0}", xpath);
            IWebElement element = driver.FindElement(By.XPath(xpath));

            element.Click();



        }


        public void Init_Selenium(int browser_selector)
        {
            System.Diagnostics.Debug.WriteLine("MESSAGE");
            if (browser_selector == 0)
            {

                try
                {
                    driver = new ChromeDriver(Chrome_Driver_Path);
                    driver.Url = "https://www.naver.com/";


                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.Clear();
                    q.SendKeys(txtdata[Querynum]);

                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch (WebDriverException w)
                {

                }


            }
            else if (browser_selector == 1)
            {

                try
                {
                    driver = new EdgeDriver();
                    driver.Url = "https://www.naver.com/";


                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.Clear();
                    q.SendKeys(txtdata[Querynum]);

                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch (WebDriverException w)
                {

                }


            }
            else if (browser_selector == 2)
            {

                try
                {
                    driver = new FirefoxDriver();
                    driver.Url = "https://www.naver.com/";

                    IWebElement q = driver.FindElement(By.Id("query"));

                    q.SendKeys(txtdata[Querynum]);
                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch (WebDriverException w)
                {

                }


            }
            else if (num == 3)
            {

                try
                {
                    driver = new InternetExplorerDriver();
                    driver.Url = "https://www.naver.com/";





                    IWebElement q = driver.FindElement(By.Id("query"));

                    q.SendKeys(txtdata[Querynum]);

                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch (WebDriverException w)
                {

                }

            }

        }
    }

            
}
