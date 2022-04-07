using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using H = Helpers.Helper;

namespace HotelAppTestsWithWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Url = "https://adactinhotelapp.com/index.php";

                IWebElement username = driver.FindElement(By.Id("username"));
                IWebElement password = driver.FindElement(By.Id("password"));

                username.SendKeys("ArthTheEagle");
                password.SendKeys("Arth@123");

                IReadOnlyCollection<IWebElement> buttons = driver.FindElements(By.Id("login"));

                foreach (var b in buttons)
                {
                    H.P(b.Text);
                    b.Click();
                }

                string xpathLocations = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td[2]/select/option[2]";

                IReadOnlyCollection<IWebElement> locations = driver.FindElements(By.XPath(xpathLocations));

                foreach (var l in locations)
                {
                    H.P(l.Text);
                    l.Click();
                }

                string xpathHotels = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[3]/td[2]/select/option[2]";
                IReadOnlyCollection<IWebElement> hotels = driver.FindElements(By.XPath(xpathHotels));
                foreach (var h in hotels)
                {
                    H.P(h.Text);
                    h.Click();
                }

                string xpathRoomType = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[4]/td[2]/select/option[2]";
                IReadOnlyCollection<IWebElement> roomType = driver.FindElements(By.XPath(xpathRoomType));
                foreach (var rt in roomType)
                {
                    H.P(rt.Text);
                    rt.Click();
                }

                string xpathnNumOfRooms = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[5]/td[2]/select/option[2]";
                IReadOnlyCollection<IWebElement> numRoom = driver.FindElements(By.XPath(xpathnNumOfRooms));
                foreach (var r in numRoom)
                {
                    H.P(r.Text);
                    r.Click();
                }

                string xpathSearch = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[10]/td[2]/input[1]";
                IReadOnlyCollection<IWebElement> search = driver.FindElements(By.XPath(xpathSearch));
                foreach (var s in search)
                {
                    H.P(s.Text);
                    s.Click();
                }

                string xpathSelect = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[2]/td[1]/input[1]";
                IReadOnlyCollection<IWebElement> select = driver.FindElements(By.XPath(xpathSelect));
                foreach (var s in select)
                {
                    H.P(s.Text);
                    s.Click();
                }

                string xpathContinue = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[3]/td/input[1]";
                IReadOnlyCollection<IWebElement> continueButton = driver.FindElements(By.XPath(xpathContinue));
                foreach (var c in continueButton)
                {
                    H.P(c.Text);
                    c.Click();
                }


                IWebElement firstNameElm = driver.FindElement(By.Id("first_name"));
                IWebElement lastNameElm = driver.FindElement(By.Id("last_name"));
                IWebElement billingAddElm = driver.FindElement(By.Id("address"));
                IWebElement creditCardElm = driver.FindElement(By.Id("cc_num"));

                firstNameElm.SendKeys("Arth");
                H.S(2);
                lastNameElm.SendKeys("Patel");
                H.S(2);
                billingAddElm.SendKeys("20 waverley ave");
                H.S(2);
                creditCardElm.SendKeys("9191919191919191");
                H.S(2);

                string xpathCardType = "/html/body/table[2]/tbody/tr[2]/td/form/table/tbody/tr[16]/td[2]/select/option[2]";
                IReadOnlyCollection<IWebElement> card = driver.FindElements(By.XPath(xpathCardType));
                foreach (var c in card)
                {
                    H.P(c.Text);
                    c.Click();
                }

                IWebElement ccMonthElm = driver.FindElement(By.Id("cc_exp_month"));
                ccMonthElm.SendKeys("December");
                ccMonthElm.SendKeys(Keys.Enter);
                IWebElement ccYearElm = driver.FindElement(By.Id("cc_exp_year"));
                ccYearElm.SendKeys("2022");
                ccYearElm.SendKeys(Keys.Enter);

                IWebElement creditCardCCElm = driver.FindElement(By.Id("cc_cvv"));
                creditCardCCElm.SendKeys("2323");


                IReadOnlyCollection<IWebElement> book = driver.FindElements(By.Id("book_now"));

                foreach (var b in book)
                {
                    H.P(b.Text);

                    b.Click();
                }

                H.S(15);

                IWebElement bookNo = driver.FindElement(By.Id("order_no"));
                H.P("The Booking number is: ");
                H.P(bookNo.GetAttribute("value"));
            }
            catch (Exception ex)
            {
                H.P(ex.Message);
            }

        }
    }
}
