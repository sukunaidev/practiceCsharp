using System;
using System.ComponentModel;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersize;

            string[] foodsinstore = {"Plain Tacos" , "Beef Tacos" , "Shrimp Tacos" , "Shrimp Alfredo"
            ,  "Alfredo Pasta" , "Fried Chicken" , "Buffalo Chicken" , "Shrimp Fried Rice"};
            double[] foodcost = { 6.00, 7.50, 8.55, 5.50, 12.30, 3.0, 4.50, 7.80 };

            List<string> foodinstock = new List<string>();
            List<double> fooditeemcost = new List<double>();

            foodinstock.AddRange(foodsinstore);
            fooditeemcost.AddRange(foodcost);
            Console.WriteLine($"All the items in stock today :");
        

            for (int e = 0; e < foodinstock.Count; e++)
            {
                Console.WriteLine($"{foodinstock[e]} ${foodcost[e]}");
            }
            int i = 0;

            Console.Write("Please enter the amount of people that will be ordering today: ");
            ordersize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The size of the party " + ordersize + " people.");

            List<string> userin = new List<string>();
            List<string> identity = new List<string>();
            List<string> fooditem = new List<string>();


            Console.WriteLine("Enter the names of the individals that'll be ordering below: ");
            var useri = Console.ReadLine();

            Console.WriteLine(useri);
            userin.Add(useri);

            foreach (string item in userin)
            {
                string[] splitnames = item.Split(" ");

                for (int p = 0; p < ordersize; p++)
                {
                    identity.Add(splitnames[p]);
                }

                
            }

            foreach (string item in identity)
            {
                Console.WriteLine(item);
            }
                /**while (i < ordersize)
                {

                    Console.Write("Enter the name of the person and what they will be ordering: ");
                    var useri = Console.ReadLine();



                    



                    i++;

                }



                foreach (string item in userin)
                {
                    string[] splitnames = item.Split(" ");

                    identity.Add(splitnames[0]);
                    fooditem.Add(splitnames[1]);


                }

                for (int n = 0; n < ordersize; n++)
                {

                    Console.WriteLine($"Name: {identity[n]} Item: {fooditem[n]}");*/
                //}
            }
    }
}
