﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CheckDistancesBetweenSameLetters
    {

        public bool CheckDistances(string s, int[] distance)
        {
            

            foreach (var i in s.ToArray().Distinct())
            {

                Regex reg = new Regex($@"(?<=\{i})(.*?)(?=\{i})");
                


                var z = i - 96;
                                
            }

            return false;
        }
    }
}
