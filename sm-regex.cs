using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/**
 *
 * Author Suleiman Al-Othman (@sulealothman)
 * Regular Expression of Social Media Accounts
 * Matched for username Github, Twitter, Instagram and Snapchat
 *
 **/

namespace sm_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> patterns = new Dictionary<string, string>()
            {
                { "Github", @"^(?!.*\-\-|.*\-$|.*_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$"},
                { "Twitter", @"^[A-z0-9_]{0,15}$"},
                { "Instagram", @"^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$"},
                { "Snapchat", @"^(?!.*\.\.|.*__|.*\-\-)(?!.*\.$|.*_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-_|.*_\-|.*\._|.*_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$"}
            };

            Console.Write("Enter your username : ");
            string username = Console.ReadLine();
            foreach (KeyValuePair<string, string> item in patterns)
            {
                Console.WriteLine("{0} : {1}", item.Key, check_pattern(item.Value, username));
            }
            Console.ReadKey();
        }

        static string check_pattern(string pattern, string text)
        {
            return new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(text) ? "Yes is matched" : "No, is not matched";
        }
    }
}
