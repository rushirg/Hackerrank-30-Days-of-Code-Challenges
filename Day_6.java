



import java.io.*;
import java.util.*;

class Lets_Review{
	public static void main( String [] args ){
		
		int test;
		Scanner scan = new Scanner( System.in );
		test = scan.nextInt();
		for( int k=0; k<test; k++ ){
			String str = scan.next();
			char str_arr[] = str.toCharArray();

			int len = str.length();
			for( int i=0; i<len; i+=2 ){
				System.out.print( str_arr[i] );
			}
			System.out.print(" ");
			for( int i=1; i<len; i+=2 ){
				System.out.print( str_arr[i]);
			}
			System.out.println("");
		}
	}
}

