using System;

namespace NUnitTestingAsgn
{
    public class Triangles
    {
        static void Main(string[] args)
        {
            int res;
            Triangles t = new Triangles();
            Console.WriteLine("Please enter values for the sides of the triangle");
            Console.Write("Enter value for side A: ");
            int valA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for side B: ");
            int valB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for side C: ");
            int valC = Convert.ToInt32(Console.ReadLine());

            if (t.sideChecker(valA, valB, valC))
            {
                res = t.isTriangle(valA, valB, valC);
                if (res == 1)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else if (res == 2)
                {
                    Console.WriteLine("Isoceles triangle");
                }
                else
                {
                    Console.WriteLine("Scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("Can not form a triangle with given sides");
            }

           

        }

        public int isTriangle(int a,int b, int c) 
        {
            if(a==b && b == c)
            {
                return 1;//equilateral triangle
            }
            else if(a==b || a==c || b == c)
            {
                return 2; //isoceles triangle
            }
            else
            {
                return 3; //scalene triangle
            }
            
        }

        public Boolean sideChecker(int a, int b, int c)
        {
            if(a<=0 || b<=0 || c <= 0)
            {
                return false; //checks for the sides if any side is <= 0 then its not good
            }
            else
            {
                return true; //else return true
            }
        }
    }
}
