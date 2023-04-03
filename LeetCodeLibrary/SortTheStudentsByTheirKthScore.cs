using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SortTheStudentsByTheirKthScore
    {
        public int[][] SortTheStudents(int[][] score, int k)
        {

            Dictionary<int, int[]> studentsNotes = new Dictionary<int, int[]>();

            for (int i = 0; i < score.Length; i++)
            {
                studentsNotes.Add(score[i].Skip(k).FirstOrDefault(), score[i]);
            }

            var myList = studentsNotes.ToList();
            myList.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            return myList.Select(x => x.Value).Reverse().ToArray();

        }
    }
}
