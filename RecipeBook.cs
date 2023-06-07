using System;
using System.Collections.Generic;

namespace ST10057222_PROG2A_NEFALE;


    class Program
    {
        public static SortedDictionary<string, Recipe> recipesBk = new SortedDictionary<string, Recipe>();
        public delegate void intDelegate(int countCal);

        private static int calWrn = 0;
        
        static void Main(string[] args)
        {
            /*Get the user to make a selection from the options provided below
             * Menu:
             *      1.New recipe
             *      2.View recipe
             *      3.Clear all data
             *      3.Exit
             * 
             */

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\rWELCOME");
            Console.BackgroundColor = ConsoleColor.Black;


            // Initialize a string variable called "input" with a null value
            int input = 0;

            // Start a loop that continues until the user enters "4"
            while (input != 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Menu:");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("VIEW RECIPE");
                Console.ForegroundColor = ConsoleColor.White;
                // Display a menu of options to the user
                Console.WriteLine("select an option:");
                Console.WriteLine("1. Input new recipe");
                Console.WriteLine("2. View recipe");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3. Clear");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("4. Exit");

                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        // If the user entered "1", call a method called "newRecipe()"
                        AddRecipe();
                        break;
                    case 2:
                        // If the user entered "2", call a method called "viewRecipe()"
                        ViewRecipes(recipesBk);
                        break;
                    case 3:
                        clearData();
                        break;
                    case 4:
                        // If the user entered "3", exit the program
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("GOODBYE");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddRecipe()
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("New recipe");
            Console.ForegroundColor = ConsoleColor.White;
            
            Recipe recipe = new Recipe();
            
            Console.WriteLine("Enter recipe name:");
            string name = Console.ReadLine();

            if (recipesBk.ContainsKey(name))
            {
                Console.WriteLine("Recipe with the same name already exists.");
                return;
            }
            
            recipe.setName(name);
                
            List<Ingredient> iList = new List<Ingredient>();
            
            Console.WriteLine("Enter number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine("Enter ingredient name:");
                string iName= Console.ReadLine();

                // Ask the user to enter the quantity of the ingredient
                double iquantity = 0;
                
                bool flag0 = false;
                do
                {
                    
                    Console.WriteLine("Please enter the quantity of the ingredient: ");
                    if (double.TryParse(Console.ReadLine(), out double tea)) {

                        iquantity = tea;
                        flag0 = true;

                    } 
                    else 
                    {

                        Console.WriteLine("Incorrect input!!!\nPlease only make use of numbers as well as use \",\" for decimal points ");
                    
                    }
                   
                }
                while (flag0 == false);
                
                
                // Ask the user to select the unit of measurement for the ingredient
                string iUnit = null;
                bool flag1 = false;
                do 
                {
                    Console.WriteLine("Please enter the unit of measurementConsole.WriteLine:\r\n 1. teaspoon\r\n 2. tablespoon\r\n 3. cup\n");
                    string choice = Console.ReadLine();

                    // Use a switch statement to set the unit of measurement based on the user's choice
                    switch (choice) 
                    {

                        case "1":
                            iUnit ="teaspoon";
                            flag1 = true;
                            break; 
                        case "2":
                            iUnit = "tablespoon";
                            flag1 = true;
                            break; 
                        case"3":
                            iUnit = "cup";
                            flag1 = true;
                            break;
                        default: Console.WriteLine("Incorrect selection!");
                            break;
                    
                    }
                    

                } while (flag1 != true);


                string iFG = null;
                bool flag2 = false;
                do 
                {
                    
                    // Ask the user to enter the food group of the ingredient
                    Console.WriteLine("Please select the food group of the ingredient: \n1. Starchy foods\n2. Vegetables and fruits\n3. Dry beans, peas, lentils and soya\n4. Chicken, fish, meat and eggs\n5. Milk and dairy products\n6. Fats and oil\n7. Water");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {

                        case "1":
                            iFG = "Starchy foods";
                            flag2 = true;
                            break;
                        case "2":
                            iFG = "Vegetables and fruits";
                            flag2 = true;
                            break;
                        case "3":
                            iFG =  "Dry beans, peas, lentils and soya";
                            flag2 = true;
                            break;
                        case "4":
                            iFG = "Chicken, fish, meat and eggs";
                            flag2 = true;
                            break;
                        case "5":
                            iFG = "Milk and dairy products";
                            flag2 = true;
                            break;
                        case "6":
                            iFG = "Fats and oil";
                            flag2 = true;
                            break;
                        case "7":
                            iFG = "Water";
                            flag2 = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect input/selection!!");
                            break;

                    }

                } while (flag2 != true);

                int icalories = 0;
                bool flag3 = false;
                do
                {

                    // Ask the user to enter the quantity of the ingredient
                    Console.WriteLine("Please enter the amount calories in the ingredient: ");
                    if (int.TryParse(Console.ReadLine(), out int tea)) {

                        icalories = tea;
                        warning(icalories);
                        flag3 = true;

                    } 
                    else 
                    {

                        Console.WriteLine("Incorrect input!!!\nPlease only make use of numbers as well as use \",\" for decimal points ");
                    
                    }
                   
                }
                while (flag3 == false);
                
                iList.Add(new Ingredient(iName,iquantity,iUnit,icalories,iFG));
            }
            recipe.setIngredients(new List<Ingredient>(iList));
            
            Console.WriteLine("Enter number of steps:");
            int stepCount = int.Parse(Console.ReadLine());
            IDictionary<int, string> sList = new Dictionary<int, string>();
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine("Enter step:");
                string step = Console.ReadLine();
                sList.Add(i+1,step);
            }
            
            recipe.setSteps(sList);
            recipesBk.Add(recipe.getName(),new Recipe(recipe.getName(),recipe.getIngredients(),recipe.getSteps()));
            
            Console.WriteLine("Recipe added successfully.\n\n");
        }
        
        
        

        static void ViewRecipes(SortedDictionary<string, Recipe> recipes)
        {
            
            
            /*Dispplay the recipe in full 
                * View recipe:
                *      scale- 
                *          1. x1
                *          2. x0.5
                *          3. x2
                *          4. x3
                *          5. Return 
                * 
                */
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("View recipes");
            Console.ForegroundColor = ConsoleColor.White;
            
            
            
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            bool flag = false;
            do
            {
                
                Console.WriteLine("Select a recipe to view:");

                int index = 1;
                foreach (var recipe in recipes)
                {
                    Console.WriteLine($"{index}. {recipe.Key}");
                    index++;
                }
                
                int selectedRecipeIndex = int.Parse(Console.ReadLine());

                if (selectedRecipeIndex < 1 || selectedRecipeIndex > recipes.Count)
                {
                    Console.WriteLine("Invalid recipe index.");
                    return;
                }
                
                string selectedRecipeName = recipes.Keys.ElementAt(selectedRecipeIndex - 1);
                Recipe selectedRecipe = recipes[selectedRecipeName];
                
                Console.WriteLine("By what factor would you like to view the recipe: \n\t1. 0.5x\n\t2. Original\n\t3. x2\n\t4. x3\n\t5. <----Return");
                string options = Console.ReadLine();

                int totalCal = 0;
                switch (options)
                {
                    
                    case "1":
                        

                        Console.WriteLine($"Recipe: {selectedRecipe.getName()}");

                        Console.WriteLine("\tIngredients:");
                        foreach (var ingredient in selectedRecipe.getIngredients())
                        {

                            double temp = 0;
                            if (ingredient.getMeasurment() == "tablespoon")
                            {
                                
                                temp = ingredient.getQuantity()*3;
                                
                            }
                            
                            string[] storage = new string[2] { Convert.ToString(temp/2),ingredient.getMeasurment()};
                            Console.WriteLine("\t" + ingredient.getName() + " " + scale(storage) + "\n\t"+ ingredient.getFoodgroup() + "\n\t " + ingredient.getCalories() + " calories") ;
                            totalCal += ingredient.getCalories();
                        }
                        
                        Console.WriteLine("Total calories: " + totalCal);
                        Console.WriteLine("Steps:");
                        foreach (var step in selectedRecipe.getSteps())
                        {
                            Console.WriteLine(step);
                        }

                        totalCal = 0;
                        break;
                    case "2":
                        
                        Console.WriteLine($"Recipe: {selectedRecipe.getName()}");

                        Console.WriteLine("\tIngredients:");
                        foreach (var ingredient in selectedRecipe.getIngredients())
                        {

                            double temp = 0;
                            if (ingredient.getMeasurment() == "tablespoon")
                            {
                                
                                temp = ingredient.getQuantity()*3;
                                
                            }
                            
                            string[] storage = new string[2] { Convert.ToString(temp),ingredient.getMeasurment()};
                            Console.WriteLine("\t" + ingredient.getName() + " " + scale(storage) + "\n\t"+ ingredient.getFoodgroup() + "\n\t " + ingredient.getCalories() + " calories") ;
                            totalCal += ingredient.getCalories();
                        }

                        Console.WriteLine("Steps:");
                        foreach (var step in selectedRecipe.getSteps())
                        {
                            Console.WriteLine(step);
                        }

                        totalCal = 0;
                        break;
                    case "3":

                        Console.WriteLine($"Recipe: {selectedRecipe.getName()}");

                        Console.WriteLine("\tIngredients:");
                        foreach (var ingredient in selectedRecipe.getIngredients())
                        {

                            double temp = 0;
                            if (ingredient.getMeasurment() == "tablespoon")
                            {
                                
                                temp = ingredient.getQuantity()*3;
                                
                            }
                            
                            string[] storage = new string[2] { Convert.ToString(temp*2),ingredient.getMeasurment()};
                            Console.WriteLine("\t" + ingredient.getName() + " " + scale(storage) + "\n\t"+ ingredient.getFoodgroup() + "\n\t " + ingredient.getCalories() + " calories") ;
                            totalCal += ingredient.getCalories();
                        }

                        Console.WriteLine("Steps:");
                        foreach (var step in selectedRecipe.getSteps())
                        {
                            Console.WriteLine(step);
                        }

                        totalCal = 0;
                        break;
                    case "4":
                        
                        Console.WriteLine($"Recipe: {selectedRecipe.getName()}");

                        Console.WriteLine("\tIngredients:");
                        foreach (var ingredient in selectedRecipe.getIngredients())
                        {

                            double temp = 0;
                            if (ingredient.getMeasurment() == "tablespoon")
                            {
                                
                                temp = ingredient.getQuantity()*3;
                                
                            }
                            
                            string[] storage = new string[2] { Convert.ToString(temp*3),ingredient.getMeasurment()};
                            Console.WriteLine("\t" + ingredient.getName() + " " + scale(storage) + "\n\t"+ ingredient.getFoodgroup() + "\n\t " + ingredient.getCalories() + " calories") ;
                            totalCal += ingredient.getCalories();
                        }

                        Console.WriteLine("Steps:");
                        foreach (var step in selectedRecipe.getSteps())
                        {
                            Console.WriteLine(step);
                        }

                        totalCal = 0;
                        break;
                    case "5":
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                    
                    
                }


            }while (flag != true);
            
                        
        }
        
        
        
        public static string scale(string[] storage) {

            // Parse the input teaspoon value from the storage array
            double teaspoon = double.Parse(storage[0]);
            string outp = null;

            // Check if teaspoon is greater than or equal to 3 and the target unit is not "cup"
            if (teaspoon >= 3 && !storage[1].Equals("cup")) 
            {
                // Calculate the remainder after dividing teaspoon by 3
                double temp1 = teaspoon % 3;
                // Calculate the whole number of tablespoons
                double tablespoon = (teaspoon - temp1) / 3;
                // Round the remainder to 2 decimal places
                teaspoon = Math.Round(temp1, 2, MidpointRounding.ToEven);

                // Check if tablespoon is greater than or equal to 16
                if (tablespoon >= 16) {
                    // Calculate the remainder after dividing tablespoon by 16
                    double temp2 = tablespoon % 16;
                    // Calculate the whole number of cups
                    double cup = (tablespoon - temp2) / 16;
                    // Update tablespoon with the remainder
                    tablespoon = temp2;

                    // Construct the output string with cups, tablespoons, and teaspoons
                    outp = cup + " cups " + tablespoon.ToString() + " tablespoons " + teaspoon + " teaspoons";
                    return outp;
                } else {
                    // Construct the output string with tablespoons and teaspoons
                    outp = tablespoon.ToString() + " tablespoons " + teaspoon + " teaspoons";
                    return outp;
                }
            } else {
                // If teaspoon is less than 3 or the target unit is "cup", return the original teaspoon value with the target unit
                outp = teaspoon + " " + storage[1];
                return outp;
            }
        }

        public static  void clearData()
        {
            
            recipesBk.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tAll data has been cleared!!!\n");
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        private static intDelegate warning = (int calories) =>
        {

            calWrn += calories;

            if (calWrn > 300)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THE CALORIES IN THIS RECIPE EXCEED 300!!!");
                Console.ForegroundColor = ConsoleColor.White;

            }

        };

    }
    