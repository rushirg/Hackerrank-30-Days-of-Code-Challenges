

	static void levelOrder(Node root){
  		//Write your code here
        Queue<Node> q = new Queue<Node>();

        q.Enqueue(root);
        
        while( q.Count > 0 ){
            Node deqNode = q.Dequeue();
            Console.Write("{0} ", deqNode.data);
            if( deqNode.left != null )
                q.Enqueue(deqNode.left);
            if( deqNode.right != null )
                q.Enqueue( deqNode.right );
        }
    }
