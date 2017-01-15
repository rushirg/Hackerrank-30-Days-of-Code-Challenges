



import java.io.*;
import java.util.*;

class Loop1{
	public static void main( String [] args ){
		int input;
		Scanner scan = new Scanner( System.in );
		input = scan.nextInt();
		if( input>=2 && input <=20 ){
			for( int i=1; i<=10 ; i++ ){
				System.out.println(input+ " x "+ i+" = "+input*i);
			}
		}
		else{}
	}
} 

