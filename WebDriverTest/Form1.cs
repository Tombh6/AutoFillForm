using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebDriverTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.marketinginternetdirectory.com/submit.php");

            //Find form element to auto fill on form page - Right click on input->inspect

            var title_field = driver.FindElement(OpenQA.Selenium.By.XPath("/html/body/div[6]/div[2]/div/form/table/tbody/tr[3]/td[2]/input"));
            if(title_field != null)
            {
                //Perform actions on this element

                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field);
                actions.Click();
                actions.SendKeys("Tom");//Write what you want to be in the field
                actions.Build().Perform();
                
            }
            

        }
    }
}
