using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Headless;

namespace Zirpl.Nuget.PackageDelister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PostEntry> parameters = new List<PostEntry>();
            using (var browser = new Browser())
            {
                var loginPage = browser.GoTo<LoginPage>();
                Console.Write("Enter your nuget username: ");
                var username = Console.ReadLine();
                Console.Write("Enter your nuget password: ");
                var password = GetPassword();
                Console.WriteLine();

                parameters.Clear();
                parameters.Add(new PostEntry("SignIn.UserNameOrEmail", username));
                parameters.Add(new PostEntry("SignIn.Password", password));
                parameters.Add(new PostEntry("ReturnUrl", "/"));
                parameters.Add(new PostEntry("LinkingAccount", "false"));
                parameters.Add(new PostEntry("__RequestVerificationToken",
                    loginPage.Find<HtmlElement>()
                        .ById("signIn")
                        .Find<HtmlInput>()
                        .ByName("__RequestVerificationToken")
                        .Value));

                browser.PostTo(parameters, new Uri("https://www.nuget.org/users/account/SignIn"));
                if (browser.Page.IsOn(new Uri("https://www.nuget.org/")))
                {
                    Console.WriteLine("logged in");

                    var myPackagesPage = browser.GoTo<MyPackagesPage>();
                    var myPackagesCurrentlyPublishedHtmlLinks = myPackagesPage.Find<HtmlElement>()
                                .ById("published")
                                .Find<HtmlLink>().AllByPredicate(o => o.AttributeExists("title") && o.GetAttribute("title") == "View package page." && o.Text != "...").ToArray();

                    int i = 1;
                    foreach (var packageLink in myPackagesCurrentlyPublishedHtmlLinks)
                    {
                        Console.WriteLine(i + ") " + packageLink.Href.Replace(@"/packages/", null).Replace(@"/", null));
                        i++;
                    }

                    Console.Write("Which package would you like to unlist in its entirety? ");
                    var input = Console.ReadLine();
                    String packageName = null;
                    var number = 0;
                    if (Int32.TryParse(input, out number))
                    {
                        packageName = myPackagesCurrentlyPublishedHtmlLinks[number - 1].Href.Replace(@"/packages/", null)
                            .Replace(@"/", null);
                    }
                    else
                    {
                        packageName = input;
                    }
                    if (!String.IsNullOrWhiteSpace(packageName))
                    {
                        var cont = true;
                        while (cont)
                        {
                            var packagesPage = browser.GoTo<PackagesPage>();
                            Console.WriteLine("at packages page");

                            var links = packagesPage.Find<HtmlElement>()
                                .ById("published")
                                .Find<HtmlLink>()
                                .AllByPredicate(o => o.GetAttribute("title") == "Delete"
                                                     && o.Href.Contains(String.Format("/{0}/", packageName)));

                            cont = links.Count() >= 1;
                            if (links.Any())
                            {
                                var htmlLink = links.First();
                                var linkPage = htmlLink.Href;
                                Console.WriteLine(linkPage);
                                var deletePackagePage = htmlLink.Click();

                                parameters.Clear();
                                parameters.Add(new PostEntry("Listed", "false"));
                                parameters.Add(new PostEntry("__RequestVerificationToken",
                                    deletePackagePage.Find<HtmlElement>()
                                        .ById("body")
                                        .Find<HtmlInput>()
                                        .ByName("__RequestVerificationToken")
                                        .Value));

                                browser.PostTo(parameters, new Uri("https://www.nuget.org" + linkPage));
                                Console.WriteLine("delete submitted");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("login failed");
                }
            }
            Console.WriteLine("Hit any key to quit");
            Console.ReadKey();
        }
        public class LoginPage : HtmlPage
        {

            public override Uri TargetLocation
            {
                get { return new Uri("https://www.nuget.org/users/account/LogOn?returnUrl=%2F"); }
            }
        }
        public class MyPackagesPage : HtmlPage
        {
            public override Uri TargetLocation
            {
                get { return new Uri("https://www.nuget.org/account/Packages"); }
            }
        }
        public class PackagesPage : HtmlPage
        {
            public override Uri TargetLocation
            {
                get { return new Uri("https://www.nuget.org/account/Packages"); }
            }
        }

        public static String GetPassword()
        {
            String pwd = "";
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
                        pwd.Substring(0, pwd.Length -1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    pwd += i.KeyChar;
                    Console.Write("*");
                }
            }
            return pwd;
        }
    }
}
