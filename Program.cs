using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

class Program
{
  static async Task Main(string[] args)
  {
    string url = "https://www.finn.no/job/fulltime/search.html?location=2.20001.22046.20220&q=it";

    Console.WriteLine("Opening IT-related job listings in Bergen...");

    using var playwright = await Playwright.CreateAsync();
    await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false});
  }
}