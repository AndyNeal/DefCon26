using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Common
{
    public class Frequency
    {
        public static List<CharCount> CharsFromString(string str)
        {
            var result = new List<CharCount>();
            var chars = str.ToCharArray();
            foreach (char chr in chars)
            {
                bool found = false;
                foreach(var pair in result)
                {
                    if (pair.Character == chr)
                    {
                        pair.Count++;
                        found = true;
                    }
                }
                if (!found)
                {
                    var item = new CharCount() { Character = chr, Count = 1 };
                    result.Add(item);
                }
            }

            var orderedResult = result.OrderByDescending(x => x.Count).ToList();

            return orderedResult;
        }

        public static List<LocationData> LocationsInString(string str, char[] chars)
        {
            var chrs = str.ToCharArray();
            var result = new List<LocationData>();

            int i = 0;
            foreach (char chr in chrs)
            {
                if (chars.Contains(chr))
                {
                    if (result.Any(l => l.Character == chr))
                    {
                        result.Single(l => l.Character == chr).Locations.Add(i);
                    }
                    else
                    {
                        result.Add(new LocationData() { Character = chr, Locations = new List<int>() { i } });
                    }
                }
                i++;
            }

            return result;
        }

        public static string DropFromString(string str, char[] chrs, char replace = ' ')
        {
            var chars = str.ToCharArray();
            string result = "";
            foreach (char chr in chars)
            {
                if (chrs.Contains(chr))
                {
                    result += replace;
                }
                else
                {
                    result += chr;
                }
            }
            return result;
        }

        public static string DropAllExceptFromString(string str, char[] chrs, char replace = ' ')
        {
            var chars = str.ToCharArray();
            string result = "";
            foreach (char chr in chars)
            {
                if (chrs.Contains(chr))
                {
                    result += chr;
                }
                else
                {
                    result += replace;
                }
            }
            return result;
        }

    }

    public class CharCount
    {
        public char Character;
        public int Count;
    }

    public class LocationData
    {
        public char Character;
        public List<int> Locations;
    }


}
