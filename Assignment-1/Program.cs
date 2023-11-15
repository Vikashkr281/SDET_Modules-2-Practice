using NUnit.Framework;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Amazone test = new Amazone();
            try
            {
                test.ChromeInsilizerTest();
                test.TestTitle();
                test.TestUrl();
                Console.WriteLine("Succesfull");
            }
            catch (AssertionException)
            {
                Console.WriteLine("fail");
            }
            test.Close();
        }
    }
}