

//Write your code here
class Calculator:AdvancedArithmetic{

       public int divisorSum( int n ){
           int sum = 0;
           for( int i=1; i<=Math.Sqrt(n); i++ ){
               if( n%i == 0 ){
                   if( n/i == i ){
                        sum+=i;    
                   }
                   else{
                       sum+=i;
                       sum+=(n/i);
                   }
               }
           }
           return sum;
       }
}
