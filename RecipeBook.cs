namespace ST10057222_PROG2A_NEFALE;

class RecipeBook
{
        
    private static List<Recipe> bookRecipes = new List<Recipe>();
    
    public static void Main()
    {


        /*Get the user to make a selection from the options provided below
        * Menu:
        *      1.New recipe
        *      2.View recipe
        *      3.Exit
        * 
        */

        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t\t\tWELCOME");
        Console.BackgroundColor = ConsoleColor.Black;


        // Initialize a string variable called "input" with a null value
        string input = null;

        // Start a loop that continues until the user enters "4"
        while (input != "4")
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\tMenu:");
            Console.BackgroundColor = ConsoleColor.Black;

            // Display a menu of options to the user
            Console.WriteLine("select an option:");
            Console.WriteLine("1. Add new recipe");
            Console.WriteLine("2. View recipes");
            Console.WriteLine("3. Clear all data");
            Console.WriteLine("4. Exit");

            // Read the user's input from the console
            input = Console.ReadLine();

            // Use a switch statement to determine which action to take based on the user's input
            switch (input)
            {
            
                case "1":
                    // If the user entered "1", call a method called "newRecipe()"
                    addRecipe();
                    Console.WriteLine("\n\n");
                    break;
                case "2":
                    // If the user entered "2", call a method called "viewRecipe()"
                    viewRecipes();
                    break;
                case "3":
                    //clearData();
                    break;
                case "4":
                    // If the user entered "3", exit the program
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GOODBYE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(-1);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIncorrect selection/input!!!!!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
                
        }
            
    }
        
        
    public static void addRecipe()
    {
        string input = null;
        Recipe cookRecipe = new Recipe();
        Ingredient igrdnt = new Ingredient();
        List<Ingredient> ingredientsList = new List<Ingredient>();
        IDictionary<int, string> steps = new Dictionary<int, string>();

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("Add new recipe:\n");
        Console.BackgroundColor = ConsoleColor.Black;

        // Ask the user to enter the name of the recipe
        Console.WriteLine("Please enter the name of the recipe");
        input = Console.ReadLine();
        cookRecipe.setRecipeName(input);
            
        
        
        
        // Ask the user to enter the number of ingredients in the recipe
        Console.WriteLine("Please enter the number of ingredients in the recipe: ");
        int numOfIngredients = int.Parse(Console.ReadLine());

        for (int a = 0; a<numOfIngredients;a++)
        {
                
            // Ask the user to enter the ingredient name
            Console.WriteLine("Please enter the name of the ingredient: ");
            igrdnt.setName(Console.ReadLine());
                
            bool flag0 = false;
            do
            {

                // Ask the user to enter the quantity of the ingredient
                Console.WriteLine("Please enter the quantity of the ingredient: ");
                input = Console.ReadLine();
                
                if (double.TryParse(input, out double tea)) 
                {
                    
                    igrdnt.setQuantity(tea);
                    flag0 = true;

                } 
                else 
                {

                    Console.WriteLine("Incorrect input!!!\nPlease only make use of numbers as well as use \",\" for decimal points ");
                    
                }
                
            }
            while (flag0 == false);
            
            // Ask the user to select the unit of measurement for the ingredient
            bool flag1 = false;

            do {
                Console.WriteLine(
                    "Please enter the unit of measurement:\r\n 1. teaspoon\r\n 2. tablespoon\r\n 3. cup\n");
                string choice = Console.ReadLine();

                // Use a switch statement to set the unit of measurement based on the user's choice
                switch (choice) 
                {

                    case "1":
                        igrdnt.setMeasurment("teaspoon");
                        flag1 = true;
                        break; 
                    case "2":
                        igrdnt.setMeasurment("tablespoon");
                        flag1 = true;
                        break; 
                    case"3":
                        igrdnt.setMeasurment("cup");
                        flag1 = true;
                        break;
                    default: Console.WriteLine("Incorrect selection");
                        break;
                    
                }
                    

            } while (flag1 != true);
            
        }

        
        // The user is asked to enter the number of steps in the recipe.
        Console.WriteLine("Please enter the number of steps in this recipe");
        int numOfSteps = int.Parse(Console.ReadLine());
            
        int count = 1;

        // The user is prompted to enter each step in the recipe.
        for(int b = 0; b < numOfSteps; b++)
        {
                
            Console.WriteLine("Please enter step " + count + " of the recipe: ");
            steps.Add(count,Console.ReadLine());
                
            count++;

        }
            
            
        ingredientsList.Add(igrdnt);
        cookRecipe.setlistOfIngredient(ingredientsList);
        cookRecipe.setProcedures(steps);
            
        bookRecipes.Add(cookRecipe);
        
        
    }
    
    public static void viewRecipes()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("VIEW RECIPE");
        Console.BackgroundColor = ConsoleColor.Black;
        
        Recipe r1 = new Recipe();
        Console.WriteLine("Here is a list of recipes you could try:");
        for (int c = 0; c < bookRecipes.Count; c++)
        {

            //get the recipe information from the RecipeArray class
            r1 = bookRecipes[c];
            Console.WriteLine(c+1+ " " + r1.getRecipeName());
            
        }

        
        bool flag0 = false;
        do
        {

            // Ask the user to enter the quantity of the ingredient
            Console.WriteLine("Please enter the number of the recipe you want to view:");
            string input = Console.ReadLine();
                
            if (int.TryParse(input, out int selection) && selection <= bookRecipes.Count) 
            {
                    
                scale(selection);
                flag0 = true;

            } 
            else 
            {

                Console.WriteLine("Incorrect input!!!\nPlease only make use of numbers ONLY");
                    
            }
                
        }
        while (flag0 == false);

        IDictionary<int, string> step = r1.getProcedure();

        foreach(KeyValuePair<int, string> kvp in step)
            Console.WriteLine("Step{0}: {1}", kvp.Key, kvp.Value);
        
        //bookRecipes = 
        //List<Ingredient> ingredientsList = new List<Ingredient>();
            
    }

    public static void scale(int slct)
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
        
        
        
    }

}
    

