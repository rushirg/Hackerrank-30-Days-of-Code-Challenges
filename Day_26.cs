

using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int act_d, act_m, act_y;
        int exp_d, exp_m, exp_y;
        int fine=0;

        string[] token1 = Console.ReadLine().Split();

        act_d = int.Parse(token1[0]);
        act_m = int.Parse(token1[1]);
        act_y = int.Parse(token1[2]);

        string[] token2 = Console.ReadLine().Split();

        exp_d = int.Parse(token2[0]);
        exp_m = int.Parse(token2[1]);
        exp_y = int.Parse(token2[2]);

        if(act_y < exp_y){   // Condition 1
           fine=0;
        }else{
            if(act_y > exp_y){   // Condition 4
                fine=10000;
            }else if(act_m > exp_m){    // Condition 3
                fine=500 * (act_m - exp_m);
            }else if(act_d > exp_d){     // Condition 2
                fine=15 * (act_d - exp_d);
            }
        }
        Console.WriteLine(fine);
    }
}
