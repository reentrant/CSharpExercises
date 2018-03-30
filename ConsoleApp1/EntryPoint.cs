using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");
        
        Console.WriteLine("Selenium WebDriver with C#");
        Console.WriteLine("Happy Testing!!!");
        Console.ReadKey();
        //Thread.Sleep(1000);
        driver.Quit();

    }
}

