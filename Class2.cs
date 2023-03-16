using System;

public class Class1
{
	public Class1()
	{static void Main(string[] args) 
        {

            int questions;
            Console.WriteLine("enter the number of questions that constitute the scripts");
            questions = Convert.ToInt32(Console.ReadLine());


            if (questions > 0)
            {
                for (int i = 0; i >= questions; i++)
                {
                    int subtotal;
                    Console.WriteLine("Enter the subtotal for each of the questions in the scripts");
                    subtotal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sum of subtotal: {0}", subtotal);
                }
            }
        }

        

    }
}
