using System;

namespace assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //alex corson formative assessment 1
            Console.WriteLine("enter a whole number for the length of a cube side in cm");
            string temp = Console.ReadLine();
            int side = Convert.ToInt32(temp);
            //this will request the user to type how long one of the edges of a cube is 

            int volume = side * side * side;
            Console.WriteLine(volume);
            //used to calculate the volume where one of the edges is known by cubing that value
            //and then wrtiing what that value is to the user
        }
    }
}
