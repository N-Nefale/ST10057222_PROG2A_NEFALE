
class Recipe
{ 


    public Recipe()
    {
    
    
    }

 }



class RecipeBook
{

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


        // Initialize a string variable called "input" with a null value
        string input = null;

        // Start a loop that continues until the user enters "4"
        while (input != "4")
        {
            // Display a menu of options to the user
            Console.WriteLine("select an option:");
            Console.WriteLine("1. Input new recipe");
            Console.WriteLine("2. View recipe");
            Console.WriteLine("3. Exit");

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
                case "3":
                    // If the user entered "3", exit the program
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


        // Ask the user to enter the name of the recipe
        Console.WriteLine("Please enter the name of the recipe: ");
        string recipeName = Console.ReadLine();

        // Ask the user to enter the number of ingredients in the recipe
        Console.WriteLine("Please enter the number of ingredients in the recipe: ");
        int numOfIngredients = int.Parse(Console.ReadLine());
        int a = 0;

        // Create arrays to hold the ingredients, quantities, and units of measurement
        string[] ingredientsList = new string[numOfIngredients];
        string[] ingredientsQuantity = new String[numOfIngredients];
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
            Boolean flag1 = false;

            do
            {
                Console.WriteLine(
                    "Please enter the unit of measurementConsole.WriteLine:\r\n 1. teaspoon\r\n 2. tablespoon\r\n 3. cup\r\n 4. quart");
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
                else if (choice.Equals("4"))
                {

                    ingredientsMeasurement[a] = "quart";
                    flag1 = true;

                }
                else
                {
                    Console.WriteLine("Incorrect selection");
                }


            } while (flag1 != true);

            a++;

        }


        Console.ReadKey();

    }




    public static void viewRecipe()
    {

        /*Dispplay the recipe in full 
             * View recipe:
             *      scale- 
             *          1. x1
             *          2. x2
             *          3. x3
             *          4. x4
             * 
             */


    }


}