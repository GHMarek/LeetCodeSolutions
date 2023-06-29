using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ExecutionOfAllSuffixInstructionsStayingInAGrid
    {
        public int[] ExecuteInstructions(int n, int[] startPos, string s)
        {

            int[] res = new int[s.Length];
            int countMoves = 0;
            int moved = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                int[] tmpStartPos = (int[])startPos.Clone();

                for (int j = 0; j < s.Length - i; j++)
                {
                    

                    switch (s[j + i])
                    {
                        case ('R'):
                            if (tmpStartPos[1] + 1 < n)
                            {
                                countMoves++;
                                tmpStartPos[1]++;
                                moved++;
                            }
                            break;
                        case ('L'):
                            if (tmpStartPos[1] - 1 < n && tmpStartPos[1] - 1 >= 0)
                            {
                                countMoves++;
                                tmpStartPos[1]--;
                                moved++;
                            }
                            break;
                        case ('D'):
                            if (tmpStartPos[0] + 1 < n)
                            {
                                countMoves++;
                                tmpStartPos[0]++;
                                moved++;
                            }
                            break;
                        case ('U'):
                            if (tmpStartPos[0] - 1 < n && tmpStartPos[0] - 1 >= 0)
                            {
                                countMoves++;
                                tmpStartPos[0]--;
                                moved++;
                            }
                            break;

                    }

                    if (moved > 0)
                    {
                        moved = 0;
                        continue;
                    }

                    break;
                   
                }

                res[i] = countMoves;
                countMoves = 0;

            }

            return res;
        }
    }
}
