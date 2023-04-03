using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class GroupThePeopleGivenTheGroupSizeTheyBelongTo
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {

            List<IList<int>> resList = new List<IList<int>>();
            
            Dictionary<int, List<int>> resDict = new Dictionary<int, List<int>>();
            int index = 0;

            foreach (int i in groupSizes)
            {

                if (resDict.ContainsKey(i))
                {


                    resDict[i].Add(index);

                    // once we collect full group, we move it to result and clean dictionary
                    CopyGroup(resList, resDict, i);

                    index++;
                    continue;
                }

                resDict.Add(i, new List<int>() { index } );

                CopyGroup(resList, resDict, i);

                index++;

            }



            return resList;

        }

        private static void CopyGroup(List<IList<int>> resList, Dictionary<int, List<int>> resDict, int i)
        {
            if (resDict[i].Count == i)
            {
                resList.Add(resDict[i]);

                resDict.Remove(i);
            }
        }
    }
}
