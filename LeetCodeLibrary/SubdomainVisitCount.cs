using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SubdomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> res = new List<string>() { };
            Dictionary<string, int> domainsDict = new Dictionary<string, int>();

            foreach (string doms in cpdomains)
            {
                int count = Int32.Parse(doms.Split(' ')[0]);
                int subdomains = doms.Count(x => x == '.');
                string[] domsArr = doms.Split(' ')[1].Split('.').ToArray();
                string fullDom = String.Empty;
                string shortDom = String.Empty;
                string topDom = String.Empty;

                switch (subdomains)
                {
                    case 2:
                        fullDom = $@"{domsArr[0]}.{domsArr[1]}.{domsArr[2]}";
                        shortDom = $@"{domsArr[1]}.{domsArr[2]}";
                        topDom = $@"{domsArr[2]}";

                        if (domainsDict.ContainsKey(fullDom)) 
                        {
                            domainsDict[fullDom] += count;
                        }
                        else
                        {
                            domainsDict.Add(fullDom, count);
                        }

                        if (domainsDict.ContainsKey(shortDom))
                        {
                            domainsDict[shortDom] += count;
                        }
                        else
                        {
                            domainsDict.Add(shortDom, count);
                        }

                        if (domainsDict.ContainsKey(topDom))
                        {
                            domainsDict[topDom] += count;
                        }
                        else
                        {
                            domainsDict.Add(topDom, count);
                        }

                        break;

                    case 1:

                        shortDom = $@"{domsArr[0]}.{domsArr[1]}";
                        topDom = $@"{domsArr[1]}";

                        if (domainsDict.ContainsKey(shortDom))
                        {
                            domainsDict[shortDom] += count;
                        }
                        else
                        {
                            domainsDict.Add(shortDom, count);
                        }

                        if (domainsDict.ContainsKey(topDom))
                        {
                            domainsDict[topDom] += count;
                        }
                        else
                        {
                            domainsDict.Add(topDom, count);
                        }

                        break;
                    default:
                        break;
                }
            }

            foreach (var i in domainsDict)
            {
                res.Add($@"{i.Value} {i.Key}");
            }

            return res;

        }
    }
}
