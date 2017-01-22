

	// Add your code here
    public Difference( int []a){
        elements = a;
    }
     
    public void computeDifference(){
        int max = -1;
        int N = elements.Length, diff;
        for( int i=0; i < N; i = i+1){
            for( int j=i+1; j<N; j = j+ 1){
                diff = Math.Abs(elements[i]-elements[j]);
                if( diff > max)
                   max = diff;
            }
        }
        maximumDifference = max;
    }

