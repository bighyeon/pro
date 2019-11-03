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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string path = @"C:\Users\danam\Desktop\ㅅㅅ.txt";
            string[] txtdata = System.IO.File.ReadAllLines(path);
            int data = txtdata.Length;

            int num = random.Next(0, 4);
            int Querynum = random.Next(data);

            

            if(num == 0)
            {
                
                try
                {
                    IWebDriver Chrome = new ChromeDriver();
                    Chrome.Url = "https://www.naver.com/";

                    IWebElement q = Chrome.FindElement(By.Id("query"));
                    q.Clear();
                    q.SendKeys(txtdata[Querynum]);

                    Chrome.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch(WebDriverException w)
                {

                }
                    
               
            }
            else if(num == 1) 
            {
                
                try
                {
                    IWebDriver Edge = new EdgeDriver();
                    Edge.Url = "https://www.naver.com/";


                    IWebElement q = Edge.FindElement(By.Id("query"));
                    q.Clear();
                    q.SendKeys(txtdata[Querynum]);

                    Edge.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch(WebDriverException w)
                {
                    
                }
               
                
            }
            else if(num == 2)
            {
                
                 try
                {
                    IWebDriver FireFox = new FirefoxDriver();
                    FireFox.Url = "https://www.naver.com/";

                    IWebElement q = FireFox.FindElement(By.Id("query"));

                    q.SendKeys(txtdata[Querynum]);
                    FireFox.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch(WebDriverException w)
                {

                }
                
                
            }
            else if(num == 3)
            {
                
                try
                {
                    IWebDriver IE = new InternetExplorerDriver();
                    IE.Url = "https://www.naver.com/";
                   
                   



                    IWebElement q = IE.FindElement(By.Id("query"));

                    q.SendKeys(txtdata[Querynum]);

                    IE.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);
                }
                catch(WebDriverException w)
                {

                }
                
            }
            

            
             
        }
    }
}
