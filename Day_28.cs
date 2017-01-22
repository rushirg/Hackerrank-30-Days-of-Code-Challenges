

using System;

class Solution{
static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int j = 0;
        string[] names = new string[N];
        for (int i = 0; i < N; i++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];

            if (emailID.EndsWith("@gmail.com"))
            {
                names[j] = firstName;
                j++;
            }
        }

        Array.Sort(names);
        for (int k = 0; k < names.Length; k++)
        {
            if (names[k] != null)
            {
                Console.WriteLine(names[k]);
            }
        }
    }
}
