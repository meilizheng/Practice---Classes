using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            {
                car.Make = "Toyota";
                car.Model = "Camry";
                car.Year = 2002;
                car.Color = "red";
                car.Mileage = 3500;
                Console.WriteLine(car.ToString());
            }

            Bike bike = new Bike("Trek", Bike.Type.Mountain, "blue", 2);
            {
                Console.WriteLine(bike.ToString());
            }

            
            List<string> Ingredients1 = new List<string>();
            Ingredients1.Add("1> 2-3 medium leeks (whites and light green parts only), trimmed.");
            Ingredients1.Add("2> 2 Tbsp unsalted butter.");
            Ingredients1.Add("3> 4 Cups vegetable or chicken stock.");
            Ingredients1.Add("4> ½ Cup heavy cream + more to finish, cold.");
            Ingredients1.Add("5> To taste kosher salt.");
            Ingredients1.Add("6> To taste freshly ground black pepper.");
            Ingredients1.Add("7> To garnish: chopped chives");
         


            List<string> Steps1 = new List<string>();
            Steps1.Add("1> Cut the leaks in half and soak them in cold water for 10 minutes.Drain and pat the leeks dry, then chop into thin strips");
            Steps1.Add("2> Melt the butter in a saucepot.Add the leeks and cook for 3 - 5 minutes or until softened.");
            Steps1.Add("3> Melt the butter in a saucepot.Add the leeks and cook for 3 - 5 minutes or until softened.");
            Steps1.Add("4> Add the stock and potatoes to the pot and bring the mixture to a simmer.");
            Steps1.Add("5> Cook, uncovered, until the potatoes are tender, about 15 - 20 minutes.");
            Steps1.Add("6> Carefully, transfer the soup to a heat - safe cylindrical container.Then, using an immersion blender, blend the soup until smooth.");
            Steps1.Add("7> Stir in the cream and season to taste with salt and pepper.");
            Steps1.Add("8> Allow the soup to cool before refrigerating until completely chilled, about 3 - 4 hours.");
            Steps1.Add("9> Serve with chopped chives and an additional drizzle of cream.");



            Recipe patatoSoup = new Recipe("Potato Soup", "A dilicious soup", new DateTime(2023,4,7), 4, Ingredients1, Steps1);
            {
                Console.WriteLine(patatoSoup.ToString());
            }          

        }
    }
}