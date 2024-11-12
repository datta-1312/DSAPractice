public class Fibonacci
{
    private Dictionary<int,int> keyValuePairs=new Dictionary<int,int>();

    public Dictionary<int,int>  KVPairs => keyValuePairs;
   
    public int Fib(int n)
    {
       
        if(n==0||n==1)
        {
            Console.Write(n);
            return n;
        }
            
        if(keyValuePairs.ContainsKey(n))
            return keyValuePairs[n];
        keyValuePairs[n] =  Fib(n-1)+Fib(n-2);

        return keyValuePairs[n];
    }
}