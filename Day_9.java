

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        if( n>=2 && n<= 12 ){
            System.out.println(factorial(n));
    //        exit(0);
        }
        else{}
    }
    public static int factorial(int n){
        if( n<=1 )
            return n;
        return n*factorial(n-1);
    }
}

