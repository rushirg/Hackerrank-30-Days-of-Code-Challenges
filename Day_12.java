

class Student extends Person{
	private int[] testScores;
    Student( String firstName, String lastName, int identification, int testScore[] )
  {
       super(firstName,lastName,identification);
        this.testScores = testScore;
    }
    
    char calculate()
    {
        int sum=0;
        for( int i=0; i<testScores.length; i++ ){
            sum+=testScores[i];
        }
        int avg = sum/testScores.length;
        if( avg>=90 && avg<=100 )
               return 'O';
        else if( avg>=80 && avg<90 )
            return 'E';
       else if( avg>=70 && avg<80 )
            return 'A';
        else if( avg>=55 && avg<70 )
            return 'P';
        else if( avg>=40 && avg<55 )
            return 'D';
        else if( avg<40 )
            return 'T';
      return ' '; 
    }
   
}
