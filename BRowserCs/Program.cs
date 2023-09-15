using BRowserCs;

public class Program
{
    public static void Main()
    {
        Browser operagx = new Browser("artursuskevits.wordpress.com");
        Console.WriteLine(operagx.Current());
        while (true)
        {
            
            Console.WriteLine("Choose your move\n1-Go to new page\n2-Go back\n3-Go forward\n4-Check browser history\n5-Update homepage\n6-Go to homepage\nElse-Stop working");
            string youser_answer = Console.ReadLine();
            if (youser_answer == "1")
            {
                Console.WriteLine("Write new link");
                string newlink = Console.ReadLine();
                operagx.GoTo(newlink);
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "2")
            {
                operagx.Back();
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "3")
            {
                operagx.Forward();
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "4")
            {
                Console.WriteLine(string.Join(", ", operagx.History()));
            }
            if (youser_answer == "5")
            {
                Browser.Change_homepage(operagx);
            }
            if (youser_answer=="6")
            {
                Browser.go_to_honepage(operagx);
            }
        }

        //Browser browser = new Browser();
        //browser.GoTo("a");
        //browser.GoTo("b");
        //browser.GoTo("c");
        //browser.Back();
        //browser.Back();
        //browser.Back();
        //Console.WriteLine(browser.Current());
        //browser.Forward();
        //Console.WriteLine(browser.Current());
        //browser.Forward();
        //Console.WriteLine(browser.Current());

        //Console.WriteLine(string.Join(", ", browser.History()));
        //// google.com, a, b, c, b, a, google.com, a, b

        //// ----
        //browser = new Browser();
        //Console.WriteLine(browser.Current());
        //browser.GoTo("facebook.com");
        //Console.WriteLine(browser.Current());
        //browser.GoTo("google.com");
        //Console.WriteLine(browser.Current());
        //browser.Back();
        //Console.WriteLine(browser.Current());
        //browser.Forward();
        //Console.WriteLine(browser.Current());
        //browser.GoTo("neti.ee");
        //Console.WriteLine(browser.Current());

        //Console.WriteLine(string.Join(", ", browser.History()));

        //// google.com, facebook.com, google.com, facebook.com, google.com, neti.ee

        //// ----

        //browser = new Browser();
        //browser.GoTo("neti.ee");
        //browser.GoTo("facebook.com");
        //browser.Back();
        //browser.Back();
        //browser.GoTo("bing.com");
        //browser.Forward();
        //browser.Forward();
        //Console.WriteLine(browser.Current());

        //Console.WriteLine(string.Join(", ", browser.History()));
        //// google.com, neti.ee, facebook.com, neti.ee, google.com, bing.com
        ////Console.
    }
}