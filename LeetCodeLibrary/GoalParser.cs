using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class GoalParser
    {
        public string Interpret(string command)
        {

            
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}
