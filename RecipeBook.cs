namespace ST10057222_PROG2A_NEFALE;

class RecipeBook
{
        
    public static List<Recipe> storage = new List<Recipe>();
    List<Ingredient> ingredientsList = new List<Ingredient>();
        
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
                    //viewRecipes();
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
            Console.WriteLine("Please enter the ingredient name: ");
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

                } 
                else 
                {

                    Console.WriteLine("Incorrect input!!!\nPlease only make use of numbers as well as use \",\" for decimal points ");
                    
                }
                   
                
            }
            while (flag0 = false);
                
        }



    }

}
    

