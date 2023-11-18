using Poiis2._0;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]
namespace Poiis2._0
{

    public class Recipe
    {
        public string Meal { get; set; }
        public Recipe(string name) => Meal = name;
        public List<Ingredient> ingredients { get; set; } = new List<Ingredient>();
        public List<Instruction> instructions { get; set; } = new List<Instruction>();

        public List<KitchenInventory> inventories { get; set; }= new List<KitchenInventory>();
        public void AddIngredients(Ingredient ingredient) => ingredients.Add(ingredient);

        public void ShowIngredients()
        {
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient.Name);

            }
        }


        public void RemoveIngredient(Ingredient ingredient) => ingredients.Remove(ingredient);

        public void AddInventory(KitchenInventory name) => inventories.Add(name);


        public void ShowInventory()
        {

            foreach (var item in inventories)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void AddInstructions(Instruction instruction) => instructions.Add(instruction);

        public void ShowInstructions()
        {
            foreach (var instruction in instructions)
            {
                Console.WriteLine(instruction.Name);

            }
        }

    }
}
