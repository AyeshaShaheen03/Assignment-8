using System;
namespace Assignment_8
{
    public class marks
    {
    
    public float sub1;
    public float sub2;
    public float sub3;
    public void sum(){
        float sum= sub1 + sub2 + sub3;
        Console.WriteLine("Sum is= " +sum);
    }
    public void average(){
        float average= (sub1 + sub2 + sub3)/3;
        Console.WriteLine("Average is = "+average);
    }
        
    }
}