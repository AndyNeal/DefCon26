using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Common;

//http://tholman.com/other/transposition/
//https://www.dcode.fr/transposition-cipher


namespace TranspositionCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string enc = "hr/m8ct.erfomn/aetwd/uce8clspwdmt/ndhp/swiouatxa_:/tcrms8ne/.a/g";
            //           "h /   t       /  t  /      sp   t/  hp/s     t   :/t   s   /  / "
            //string sanitized = Frequency.DropAllExceptFromString(enc, new char[] { 'h', 't', 'p', 's', ':', '/' }, ' ');
            //Console.WriteLine("\"" + sanitized + "\"");
            //Clipboard.SetText(sanitized);

            var counts = Frequency.CharsFromString(enc);
            foreach (var item in counts)
            {
                Console.WriteLine(item.Character + " : " + item.Count);
            }

            //var locations = Frequency.LocationsInString(enc, new char[] { 'h', 't', 'p', 's', ':', '/' });
            //foreach (var loc in locations)
            //{
            //    Console.Write(loc.Character + " :");
            //    foreach (var l in loc.Locations)
            //    {
            //        Console.Write(" " + l + ",");
            //    }
            //    Console.WriteLine();
            //}


            //int x = 31;
            //int y = 32;

            //while (x > 0)
            //{
            //    Console.Write(enc.Substring(x, 1));
            //    Console.Write(enc.Substring(y, 1));
            //    x--;
            //    y++;
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //cyberez

            //string enc = "h_/___________/__t__/______sp___t/__hp/s_________:/t___s___/__/_";

            //int working = enc.Length / 2;
            //while (working > 1)
            //{
            //    int start = 0;
            //    while (start < enc.Length)
            //    {
            //        int tempWorking = working;
            //        if (start + working > enc.Length)
            //            tempWorking = enc.Length - start;
            //        Console.WriteLine(enc.Substring(start, tempWorking));
            //        start += working;
            //    }
            //    Console.WriteLine();
            //    start = 0;
            //    working--;
            //}


            //int i = 0;
            //List<List<string>> grid = new List<List<string>>();

            //for (int j = 0; j < 8; j++)
            //{
            //    var temp = new List<string>();
            //    for (int k = 0; k < 8; k++)
            //    {
            //        temp.Add("+");
            //    }
            //    grid.Add(temp);
            //}

            //for (int j = 0; j < 8; j++)
            //{
            //    for (int k = 0; k < 8; k++)
            //    {
            //        //grid[k][j] = enc.Substring(i, 1);
            //        grid[k][j] = sanitized.Substring(i, 1);
            //        i++;
            //    }
            //}

            //for (int j = 0; j < 8; j++)
            //{
            //    for (int k = 0; k < 8; k++)
            //    {
            //        Console.Write(grid[k][j]);
            //    }
            //    Console.WriteLine();
            //}

            //var bar = Permutations.GeneratePermutations(grid);
            //StreamWriter sw = new StreamWriter("output.txt");
            //List<string> stuff = new List<string>();
            //foreach (var item in bar)
            //{
            //    //for (int j = 0; j < 8; j++)
            //    //{
            //    //    for (int k = 0; k < 8; k++)
            //    //    {
            //    //        Console.Write(item[k][j]);
            //    //        sw.Write(item[k][j]);
            //    //    }
            //    //    Console.WriteLine();
            //    //    sw.WriteLine();
            //    //}
            //    string x = item[0][0] + item[1][1] + item[2][2] + item[3][3] + item[4][4] + item[5][5] + item[6][6] + item[7][7];
            //    if (!stuff.Contains(x))
            //    {
            //        stuff.Add(x);
            //    }
            //    //Console.WriteLine();
            //    //sw.WriteLine();
            //}

            //foreach (var item in stuff)
            //{
            //    sw.WriteLine(item);
            //}

            //sw.Close();

            var key = Console.ReadKey();
        }
    }
}
