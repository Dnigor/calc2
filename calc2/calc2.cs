using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace calc2
{
    public class Calc2
    {
       public static int Add(string numbers)
       {
           var separators = new List<string>() { ",", @"\n" };
           string pattern = @"^//(.)";
           var match = Regex.Match(numbers, pattern);
           string customSeparator = match.Groups[1].Value;
           
           separators.Add(customSeparator);
           return numbers.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(s =>
                                                       {
                                                           int i;
                                                           Int32.TryParse(s, out i);
                                                           return i;
                                                       }).ToArray().Sum();
       }
    }
}
