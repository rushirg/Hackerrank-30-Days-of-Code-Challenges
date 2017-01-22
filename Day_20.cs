

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void swap( ref int a, ref int b ){
        int tmp = a;
        a = b;
        b = tmp;
    }
    
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int swapCounter = 0;
        for( int i=0; i<n; i++ ){
            for( int j=0; j<n-1; j++ ){
                if(a[j] > a[j+1]){
                    swap(ref a[j], ref a[j+1]);
                    swapCounter++;
                }
            }
            if( swapCounter == 0 )
                break;
        }
        
        Console.WriteLine("Array is sorted in {0} swaps.\nFirst Element: {1}\nLast Element: {2}", swapCounter, a[0], a[n-1]);
    }
}

