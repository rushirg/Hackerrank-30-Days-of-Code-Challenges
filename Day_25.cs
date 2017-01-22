

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static bool isPrime( int no ){
        if( no == 1 )
            return false;
        if( no == 2 )
            return true;
        int noSqrt =(int)Math.Floor(Math.Sqrt(no));

        for( int i=2; i<=noSqrt; i++){
            if( no%i == 0 )
                return false;
        }
        return true;
    }
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        while( t-->0){
            int no = int.Parse(Console.ReadLine());
            if( isPrime(no) )
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
        
        
    }
}
