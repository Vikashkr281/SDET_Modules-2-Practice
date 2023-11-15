using NUnit.Framework;

namespace Assignment_2_14nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SearchBrowser searchBrowser = new SearchBrowser();
            try
                {
                searchBrowser.WebBrowser();
                searchBrowser.SearchResultForDiwali();
                

            }
            catch (AssertionException)
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("Pass");
            searchBrowser.Closebrowser();
        }
    }
}