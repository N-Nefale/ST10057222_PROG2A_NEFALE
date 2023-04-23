
class Recipe
{

    // Declare four string arrays and one string and two integer variables as fields.
    public static string[] arry1;
    public string[] arry2;
    public string[] arry3;
    public string[] arry4;
    private static string recipeName;
    private int numOfSteps;
    private int numOfIngredients;

    // This is a constructor that takes no arguments.
    public Recipe()
    {
        // There is no code inside this constructor.
    }

    // This is a constructor that takes several arguments.
    public Recipe(string[] ary1, string[] ary2, string[] ary3, string[] ary4, string name, int num1, int num2)
    {
        // Assign the input arguments to the corresponding fields of the object.
        arry1 = ary1;
        arry2 = ary2;
        arry3 = ary3;
        arry4 = ary4;
        recipeName = name;
        numOfSteps = num1;
        numOfIngredients = num2;
    }

    // This method sets the number of steps for the recipe.
    public void setNumOfSteps(int incoming)
    {
        // Assign the input integer to the numOfSteps field of the object.
        numOfSteps = incoming;
    }

    // This method gets the number of steps for the recipe.
    public int getNumOfSteps()
    {
        // Return the numOfSteps field of the object.
        return numOfSteps;
    }

    // This method sets the number of ingredients for the recipe.
    public void setNumOfIngredients(int incoming)
    {
        // Assign the input integer to the numOfIngredients field of the object.
        numOfIngredients = incoming;
    }

    // This method gets the number of ingredients for the recipe.
    public int getNumOfIngedients()
    {
        // Return the numOfIngredients field of the object.
        return numOfIngredients;
    }

    // This method sets the recipe name.
    public void setRecipeName(string incoming)
    {
        // Assign the input string to the recipeName field of the object.
        recipeName = incoming;
    }

    // This method gets the recipe name.
    public string getRecipeName()
    {
        // Return the recipeName field of the object.
        return recipeName;
    }

    // This method sets the first array of the recipe.
    public void setArry1(string[] incoming)
    {
        // Assign the input array to the arry1 field of the object.
        arry1 = incoming;
    }

    // This method gets the first array of the recipe.
    public string[] getArry1()
    {
        // Return the arry1 field of the object.
        return arry1;
    }

    // This method sets the second array of the recipe.
    public void setArry2(string[] incoming)
    {
        // Assign the input array to the arry2 field of the object.
        arry2 = incoming;
    }

    // This method gets the second array of the recipe.
    public string[] getArry2()
    {
        // Return the arry2 field of the object.
        return arry2;
    }

    // This method sets the third array of the recipe.
    public void setArry3(string[] incoming)
    {
        // Assign the input array to the arry3 field of the object.
        arry3 = incoming;
    }

    // This method gets the third array of the recipe.
    public string[] getArry3()
    {


        return arry3;

    }



    // This method sets the fourth array of the recipe.
    public void setArry4(string[] incoming)
    {

        arry4 = incoming;

    }

    // This method gets the fourth array of the recipe.
    public string[] getArry4()
    {


        return arry4;

    }

    public static string toString()
    {

        return null;

    }


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