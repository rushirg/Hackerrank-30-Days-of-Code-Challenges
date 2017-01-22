

	static int getHeight(Node root){
      //Write your code here
        if( root == null )
            return -1;
        else{
            int lHeight = getHeight(root.left);
            int rHeight = getHeight(root.right);
            if( lHeight>rHeight )
               return lHeight+1;
            else
                return rHeight+1;
        }
    }
  
