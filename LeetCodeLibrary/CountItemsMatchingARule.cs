using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountItemsMatchingARule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int matches = 0;
            int itemsIndex = 0;

            switch (ruleKey)
            {
                case "type":
                    itemsIndex = 0;
                    break;
                case "color":
                    itemsIndex = 1;
                    break;
                case "name":
                    itemsIndex = 2;
                    break;
            }

            foreach (var i in items)
            {
                if (i[itemsIndex] != ruleValue)
                {
                    continue;
                }

                matches++;

            }


            return matches;
        }
    }
}
