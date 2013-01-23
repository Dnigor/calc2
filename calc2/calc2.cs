using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calc2
{
    public class Calc2
    {
       public static int Add(string numbers)
       {
           string[] separators = {",", @"\n"};
           return numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(s =>
                                                       {
                                                           int i;
                                                           Int32.TryParse(s, out i);
                                                           return i;
                                                       }).ToArray().Sum();
       }
    }
}
