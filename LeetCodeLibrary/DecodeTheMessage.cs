using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecodeTheMessage
    {
        public string DecodeMessage(string key, string message)
        {
            Dictionary<char, int> subTab = new Dictionary<char, int>() { };
            List<int> indX = new List<int>() { };
            List<char> chaX = new List<char>() { };

            Enumerable.Range(97, 26).ToList().ForEach(x => indX.Add(key.IndexOf(Convert.ToChar(x))));
            Enumerable.Range(97, 26).ToList().ForEach(x => chaX.Add(Convert.ToChar(x)));



            var res = message.Select(x => GetSubst(x)).ToArray();

            return String.Empty;
        }

        private char GetSubst(char ch)
        {

            throw new NotImplementedException();
        }
    }
}
