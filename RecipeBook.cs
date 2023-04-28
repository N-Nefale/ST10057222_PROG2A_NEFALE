using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ST10057222_PROG2A_NEFALE
{


    class RecipeBook
    {

        public static Recipe food = new Recipe();

        // Define a public static method called "Main"
        public static void Main()
        {




            /*Get the user to make a selection from the options provided below
             * Menu:
             *      1.New recipe
             *      2.View recipe
             *      3.Exit
             * 
             */

            Console.BackgroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\r\rWELCOME");
            Console.BackgroundColor = ConsoleColor.Black;


            // Initialize a string variable called "input" with a null value
            string input = null;

            // Start a loop that continues until the user enters "4"
            while (input != "4")
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

                // Read the user's input from the console
                input = Console.ReadLine();

                // Use a switch statement to determine which action to take based on the user's input
                switch (input)
                {
                    case "1":
                        // If the user entered "1", call a method called "newRecipe()"
                        newRecipe();
                        break;
                    case "2":
                        // If the user entered "2", call a method called "viewRecipe()"
                        viewRecipe();
                        break;
                    case"3":
                        clearData();
                        break;
                    case "4":
                        // If the user entered "3", exit the program
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("GOODBYE");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Incorrect selection");
                        break;

                }
            }
        }


        // Define a public static method called "newRecipe"
        public static void newRecipe()
        {


            /*Collect any information related to the recipe
             * New recipe:
             *          1.recipe name
             *          2.number of ingredients
             *          3.ingredients name
             *          4.quantity
             *          5.unit of measurement
             *          6.number of  steps
             *          7.input steps
             * 
             */
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("New recipe");
            Console.ForegroundColor = ConsoleColor.White;

            // Ask the user to enter the name of the recipe
            Console.WriteLine("Please enter the name of the recipe: ");
            string recipeName = Console.ReadLine();

            // Ask the user to enter the number of ingredients in the recipe
            Console.WriteLine("Please enter the number of ingredients in the recipe: ");
            int numOfIngredients = int.Parse(Console.ReadLine());
            int a = 0;

            // Create arrays to hold the ingredients, quantities, and units of measurement
            string[] ingredientsList = new string[numOfIngredients];
            string[] ingredientsQuantity = new string[numOfIngredients];
            string[] ingredientsMeasurement = new string[numOfIngredients];

            // Use a while loop to prompt the user to enter information for each ingredient
            while (a < numOfIngredients)
            {
                // Ask the user to enter the ingredient name
                Console.WriteLine("Please enter the ingredient name: ");
                ingredientsList[a] = Console.ReadLine();

                // Ask the user to enter the quantity of the ingredient
                Console.WriteLine("Please enter the quantity of the ingredient: ");
                ingredientsQuantity[a] = Console.ReadLine();

                // Ask the user to select the unit of measurement for the ingredient
                bool flag1 = false;

                do
                {
                    Console.WriteLine(
                        "Please enter the unit of measurementConsole.WriteLine:\r\n 1. teaspoon\r\n 2. tablespoon\r\n 3. cup\n");
                    string choice = Console.ReadLine();

                    // Use a switch statement to set the unit of measurement based on the user's choice
                    if (choice.Equals("1"))
                    {

                        ingredientsMeasurement[a] = "teaspoon";
                        flag1 = true;

                    }
                    else if (choice.Equals("2"))
                    {

                        ingredientsMeasurement[a] = "tablespoon";
                        flag1 = true;

                    }
                    else if (choice.Equals("3"))
                    {

                        ingredientsMeasurement[a] = "cup";
                        flag1 = true;

                    }
                    else
                    {
                        Console.WriteLine("Incorrect selection");
                    }


                } while (flag1 != true);


                

                a++;

            }


            // Call a method called "procedure()" to get the steps for the recipe
            string[] steps = procedure();

            // Set the properties of aRRys object with the recipe information
            food.setRecipeName(recipeName);
            food.setNumOfIngredients(numOfIngredients);
            food.setNumOfSteps(steps.Length);
            food.setArry1(ingredientsList);
            food.setArry2(ingredientsQuantity);
            food.setArry3(ingredientsMeasurement);
            food.setArry4(steps);


            Console.ReadKey();

        }


        public static string[] procedure()
        {

            // The user is asked to enter the number of steps in the recipe.
            Console.WriteLine("Please enter the number of steps in this recipe");
            int numOfSteps = int.Parse(Console.ReadLine());

            // An array of strings is created to store the steps entered by the user.
            string[] steps = new string[numOfSteps];
            int b = 0;
            int stepProg = 1;

            // The user is prompted to enter each step in the recipe.
            while (b < numOfSteps)
            {

                Console.WriteLine("Please enter step " + stepProg + " of the recipe: ");
                steps[b] = Console.ReadLine();

                b++;
                stepProg++;

            }

            // The array of steps is returned to the calling method.
            return steps;

        }




        public static void viewRecipe()
        {
            // get the recipe information from the RecipeArray class
            string tempVal1 = food.getRecipeName();
            string[] tempArry1 = food.getArry1();
            string[] tempArry2 = food.getArry2();
            string[] tempArry3 = food.getArry3();
            string[] tempArry4 = food.getArry4();
            int tempVal2 = food.getNumOfIngedients();
            int tempVal3 = food.getNumOfSteps();


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

            


            string selection = null;

            int counter1 = 0;

            do
            {


                // prompt the user to select a scaling option or exit
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("VIEW RECIPE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select:\r\n 1. original\r\n 2. x 0.5\r\n 3. x 2\r\n 4. x 3\r\n 5. <--- return");
                selection = Console.ReadLine();

                // display the recipe with the chosen scaling option
                switch (selection)
                {
                    // case 1: display the original recipe
                    case "1":
                        Console.WriteLine("Original\nIngredients: ");
                        for (int c = 0; c < tempVal2; c++)
                        {

                            // display the ingredient name, quantity, and unit of measurement
                            Console.WriteLine(c + 1 + ". " + tempArry1[c] + "  " + tempArry2[c] + "  " + tempArry3[c]);
                        }

                        Console.WriteLine("\nScaled\nIngredients: ");
                        for (int c = 0; c < tempVal2; c++)
                        {
                            // display the ingredient name, quantity, and unit of measurement
                            if (tempArry3[c].Equals("tablespoon"))
                            {

                                int temp = int.Parse(tempArry2[c]) * 3;
                                tempArry2[c] = temp.ToString();

                            }
                            else
                            if (tempArry3[c].Equals("cup"))
                            {

                                int temp = (int.Parse(tempArry2[c]) * 3) * 16;
                                tempArry2[c] = temp.ToString();

                            }

                            string[] storage = new string[2] { tempArry2[c], tempArry3[c] };
                            Console.WriteLine(c + 1 + ". " + tempArry1[c] + " " + scale(storage));
                        }

                        //display the step of recipe
                        Console.WriteLine("\nSteps: ");
                        counter1 = 1;
                        for (int d = 0; d < tempVal3; d++)
                        {

                            Console.WriteLine("Step " + counter1 + ". " + tempArry4[d]);
                            counter1++;
                        }

                        break;
                    // case 2: display the recipe with quantities scaled down by 50%
                    case "2":
                        Console.WriteLine("\nIngredients: ");
                        for (int c = 0; c < tempVal2; c++)
                        {
                            // scale the ingredient quantity by 0.5 and display the ingredient name, scaled quantity, and unit of measurement

                            if (tempArry3[c].Equals("tablespoon"))
                            {

                                int temp = int.Parse(tempArry2[c]) * 3;
                                tempArry2[c] = temp.ToString();

                            }
                            else
                            if (tempArry3[c].Equals("cup"))
                            {

                                int temp = (int.Parse(tempArry2[c]) * 3) * 16;
                                tempArry2[c] = temp.ToString();

                            }

                            double math = double.Parse(tempArry2[c]) / 2;
                            Console.WriteLine(c + 1 + ". " + tempArry1[c] + "  " + math + "  " + tempArry3[c]);
                        }

                        //display the step of recipe
                        Console.WriteLine("\nSteps: ");
                        counter1 = 1;
                        for (int d = 0; d < tempVal3; d++)
                        {

                            Console.WriteLine("Step " + counter1 + ". " + tempArry4[d]);
                            counter1++;
                        }

                        break;

                    // case 3: display the recipe with quantities scaled up by 200%
                    case "3":
                        Console.WriteLine("\nIngredients: ");
                        for (int c = 0; c < tempVal2; c++)
                        {
                            // scale the ingredient quantity by 2 and display the ingredient name, scaled quantity, and unit of measurement
                            if (tempArry3[c].Equals("tablespoon"))
                            {

                                int temp = int.Parse(tempArry2[c]) * 3;
                                tempArry2[c] = temp.ToString();

                            }
                            else
                            if (tempArry3[c].Equals("cup"))
                            {

                                int temp = (int.Parse(tempArry2[c]) * 3) * 16;
                                tempArry2[c] = temp.ToString();

                            }

                            double math = double.Parse(tempArry2[c]) * 2;
                            string[] storage = new string[2] { math.ToString(), tempArry3[c] };
                            Console.WriteLine(c + 1 + ". " + tempArry1[c] + " " + scale(storage));
                        }

                        //display the step of recipe
                        Console.WriteLine("\nSteps: ");
                        counter1 = 1;
                        for (int d = 0; d < tempVal3; d++)
                        {

                            Console.WriteLine("Step " + counter1 + ". " + tempArry4[d]);
                            counter1++;
                        }

                        break;

                    // case 4: display the recipe with quantities scaled up by 300%
                    case "4":
                        Console.WriteLine("\nIngredients: ");
                        for (int c = 0; c < tempVal2; c++)
                        {
                            // scale the ingredient quantity by 3 and display the ingredient name, scaled quantity, and unit of measurement
                            if (tempArry3[c].Equals("tablespoon"))
                            {

                                int temp = int.Parse(tempArry2[c]) * 3;
                                tempArry2[c] = temp.ToString();

                            }
                            else
                            if (tempArry3[c].Equals("cup"))
                            {

                                int temp = (int.Parse(tempArry2[c]) * 3) * 16;
                                tempArry2[c] = temp.ToString();

                            }

                            double math = double.Parse(tempArry2[c]) * 3;
                            string[] storage = new string[2] { math.ToString(), tempArry3[c] };
                            Console.WriteLine(c + 1 + ". " + tempArry1[c] + " " + scale(storage));
                        }

                        //display the step of recipe
                        Console.WriteLine("\nSteps: ");
                        counter1 = 1;
                        for (int d = 0; d < tempVal3; d++)
                        {

                            Console.WriteLine("Step " + counter1 + ". " + tempArry4[d]);
                            counter1++;
                        }

                        break;

                    case "5":
                        //exit
                        break;
                    default: 
                            Console.WriteLine("\nincorrect selection!!\n");
                        break;

                }


            } while (selection != "5");

        }


        public static string scale(string[] storage)
        {

            // Parse the quantity as a double from the first string in the input array
            double quant = double.Parse(storage[0]);
            // Store the unit of measurement as a string
            string units = storage[1];

            // Cast the quantity as an integer to get whole units
            int quantityTemp = (int)quant;
            // Use a switch statement to check which unit of measurement was input

                    int teaspoon = quantityTemp;
                    // If the input was in teaspoons and the quantity is at least 3 teaspoons, convert to tablespoons
                    if (teaspoon >= 3 && teaspoon > 0)
                    {

                        // Calculate how many tablespoons are in the quantity and how many teaspoons remain
                        int tablespoon = teaspoon / 3;
                        teaspoon = teaspoon - (tablespoon * 3);

                        if (teaspoon > 0)
                        {  // If there are at least 16 tablespoons, convert to cups
                            if (tablespoon >= 16 && tablespoon > 0)
                            {

                                // Calculate how many cups are in the quantity and how many tablespoons remain
                                int cup = tablespoon / 16;
                                tablespoon = tablespoon - (cup * 16);

                                if (tablespoon > 0)
                                {

                                    // If there are at least 4 cups, convert to quarts
                                    if (cup > 0)
                                    {


                                        return cup + " cup " + tablespoon + " tablespoon " + teaspoon + " teaspoon";

                                    }
                                    else
                                    {

                                        return tablespoon + " tablespoon " + teaspoon + " teaspoon";

                                    }

                                }
                                else
                                {

                                    // If there are at least 4 cups, convert to quarts
                                    if (cup > 0)
                                    {


                                        return cup + " cup " + teaspoon + " teaspoon";

                                    }
                                    else
                                    {

                                        return teaspoon + " teaspoon";

                                    }

                                }

                            }
                            else
                            {

                                return tablespoon + " tablespoon " + teaspoon + " teaspoon";


                            }
                        }
                        else
                        {

                            // If there are at least 16 tablespoons, convert to cups
                            if (tablespoon >= 16)
                            {

                                // Calculate how many cups are in the quantity and how many tablespoons remain
                                int cup = tablespoon / 16;
                                tablespoon = tablespoon - (cup * 16);

                                // If there are at least 4 cups, convert to quarts
                                if (cup > 0)
                                {


                                    return cup + " cup " + tablespoon + " tablespoon";

                                }


                            }
                            else
                            {

                                return tablespoon + " tablespoon";


                            }

                        }


                    }
                    else
                    {

                        return teaspoon + " teaspoon";

                    }
     
            return teaspoon + " " + units;

        }


        public static void clearData()
        {

            // Set the properties of aRRys object with the recipe information
            food.setRecipeName(null);
            food.setNumOfIngredients(0);
            food.setNumOfSteps(0);
            food.setArry1(null);
            food.setArry2(null);
            food.setArry3(null);
            food.setArry4(null);

        }

    }



}
