using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Classes
{
    public class Recipe
    {
        string _Name;
        string _Story;       
        DateTime _DateTime;
        int _Servings;
        List<string> Steps;
        List<string> Ingredients;

    
        public Recipe(string name, string story, DateTime dateTime, int servings, List<string> steps, List<string> ingredients)
        {
            _Name = name;
            _Story = story;
            _DateTime = dateTime;
            _Servings = servings;
            Steps = steps;
            Ingredients = ingredients;
        }

        public List<string> Steps1 { get => Steps1; set => Steps1 = value; }
        public List<string> Ingredients1 { get => Ingredients1; set => Ingredients1 = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Story { get => _Story; set => _Story = value; }
        public DateTime DateTime { get => _DateTime; set => _DateTime = value; }
        public int Servings { get => _Servings; set => _Servings = value; }       


        public override string ToString()
        {
       
            string result = string.Format("Name: {0}\n", Name);
            result += string.Format("Story: {0}\n", Story);
            result += string.Format("Date created: {0}\n", DateTime.ToShortDateString());
            result += string.Format("Servings: {0}\n", Servings);
            result += "Ingredients:\n";
            foreach (string ingredient in Ingredients)
            {
                result += string.Format("- {0}\n", ingredient);
            }
            result += "Steps:\n";
            for (int i = 0; i < Steps.Count; i++)
            {
                result += string.Format("{0}. {1}\n", (i + 1), Steps[i]);
            }
            return result;
        }
       
    }
}
