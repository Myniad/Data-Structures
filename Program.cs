using System;
using System.Text;


// stack
class Stack
{
    public int size;
    public int top;
    public char[] a;
    

    // function to check if stack is empty
    public Boolean isEmpty() { return (top < 0); }

    public Stack(int n)
    {
        top = -1;
        size = n;
        a = new char[size];
    }

    // function to push element in Stack
    public Boolean push(char x)
    {
        if (top >= size)
        {
            Console.WriteLine("Stack Overflow");
            return false;
        }
        else
        {
            a[++top] = x;
            return true;
        }
    }

    // function to pop element from stack
    public char pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return ' ';
        }
        else
        {
            char x = a[top--];
            return x;
        }
    }
}

class GFG
{
 
    public static void reverse(StringBuilder str)
    {

        int n = str.Length;
        Stack obj = new Stack(n);


        int i;
        for (i = 0; i < n; i++)
            obj.push(str[i]);

 
        for (i = 0; i < n; i++)
        {
            char ch = obj.pop();
            str[i] = ch;
        }
    }


    public static void Main(String[] args)
    {
        Console.Write("Please enter a word you would like to reverse: ");
        string input = Console.ReadLine();

        StringBuilder s = new StringBuilder(input);


        reverse(s);

 
        Console.WriteLine("Your word in reverse is: " + s);
    }
}