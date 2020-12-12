using System;
public class forloop
{
    public static void Main(string[] args)
    {
        //for syntax
        //for(initialize;condition;ncre/ decr)
        //{ statement..
        //}

        //for loop
        Console.WriteLine("---------for loop-----------");
        for(int i=0;i<=10; i++)
        {
            Console.WriteLine(i);
        }
        // create table of 2 using for loop
         Console.WriteLine("---------table of 2 using for loop-----------");
         for(int i=1;i<=10; i++)
        {
            Console.WriteLine(i* 2);
            
        }


         //Nested for loop
         Console.WriteLine("---------nested for loop-----------");
         for(int i=1;i<=5; i++)
        {
           for (int j = 1; j <=5; j++)
           {
            Console.WriteLine(i + " : "+ j);   
           }
            
            
        }

    }
}