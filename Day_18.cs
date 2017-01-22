

class Solution {
    //Write your code here
    Stack<char> stackObj = new Stack<char>();
    Queue<char> queueObj = new Queue<char>();
    
    void pushCharacter(char ch){
        stackObj.Push(ch);
    }
    
    void enqueueCharacter(char ch){
        queueObj.Enqueue(ch);
    }
    
    char popCharacter(){
        return stackObj.Pop();
    } 
    
    char dequeueCharacter(){
        return queueObj.Dequeue();
    }
    
    
