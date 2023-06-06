namespace ST10057222_PROG2A_NEFALE;

public delegate void intDelegate(int countCal);
class RecipeBook
{
        
    private static List<Recipe> bookRecipes = new List<Recipe>();
    private static int calWrng = 0;
    
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
        calWrng = 0;
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
            igrdnt.setFoodGroup();    
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
                
                Console.WriteLine("Please enter the amount of calories in this ingredient:");
                int calories = int.Parse(Console.ReadLine());
                warning(calories);


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

            // Ask the user to enter which recipe do they want to view
            Console.WriteLine("Please enter the number of the recipe you want to view:");
            string input = Console.ReadLine();
                
            if (int.TryParse(input, out int selection)) 
            {
                 
                r1 = bookRecipes[selection-1];
                scale(r1);
                flag0 = true;

            } 
            else 
            {

                Console.WriteLine("Incorrect input!!!\nPlease ONLY make use of numbers!");
                    
            }
                
        }
        while (flag0 == false);
        
            
    }

    
    
    public static void scale(Recipe display)
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
        string input = null;
        List<Ingredient> lstIngr = display.getlistOfIngredient();
        Ingredient ingrdntTemp = new Ingredient();
        string[] conv = new string[2];
        do
        {
            Console.WriteLine("Please select what factor you would like your recipe to be scaled by:\n\t1. 0.5x\n\t2. Original\n\t3. 2x\n\t4. 3x\n\t5. <---Return");
            input = Console.ReadLine();

            switch (input)
            {
                
                case "1":
                    Console.WriteLine("Recipe name: " + display.getRecipeName());
                    Console.WriteLine("\tIngredients: ");
                    for(int d = 0; d < lstIngr.Count; d++)
                    {
                        
                        ingrdntTemp = lstIngr[d];
                        Console.WriteLine(d + 1 +".\nName: " + ingrdntTemp.getName());
                        Console.WriteLine("Food group: " + ingrdntTemp.getFoodGroup());
                        conv[0] = Convert.ToString(ingrdntTemp.getQuantity()/2);
                        conv[1] = Convert.ToString(ingrdntTemp.getMeasurment());
                        Console.WriteLine(convertMass(conv));

                    }
                    break;
                case "2":
                    Console.WriteLine("Recipe name: " + display.getRecipeName());
                    Console.WriteLine("\tIngredients: ");
                    for (int d = 0; d < lstIngr.Count; d++)
                    {

                        ingrdntTemp = lstIngr[d];
                        Console.WriteLine(d + 1 + ".\nName: " + ingrdntTemp.getName());
                        Console.WriteLine("Food group: " + ingrdntTemp.getFoodGroup());
                        conv[0] = Convert.ToString(ingrdntTemp.getQuantity());
                        conv[1] = Convert.ToString(ingrdntTemp.getMeasurment());
                        Console.WriteLine(convertMass(conv));
                    }
                    break;
                case "3":
                    Console.WriteLine("Recipe name: " + display.getRecipeName());
                    Console.WriteLine("\tIngredients: ");
                    for (int d = 0; d < lstIngr.Count; d++)
                    {

                        ingrdntTemp = lstIngr[d];
                        Console.WriteLine(d + 1 + ".\nName: " + ingrdntTemp.getName());
                        Console.WriteLine("Food group: " + ingrdntTemp.getFoodGroup());
                        conv[0] = Convert.ToString(ingrdntTemp.getQuantity()*2);
                        conv[1] = Convert.ToString(ingrdntTemp.getMeasurment());
                        Console.WriteLine(convertMass(conv));
                    }
                    break;
                case "4":
                    Console.WriteLine("Recipe name: " + display.getRecipeName());
                    Console.WriteLine("\tIngredients: ");
                    for (int d = 0; d < lstIngr.Count; d++)
                    {

                        ingrdntTemp = lstIngr[d];
                        Console.WriteLine(d + 1 + ".\nName: " + ingrdntTemp.getName());
                        Console.WriteLine("Food group: " + ingrdntTemp.getFoodGroup());
                        conv[0] = Convert.ToString(ingrdntTemp.getQuantity() * 3);
                        conv[1] = Convert.ToString(ingrdntTemp.getMeasurment());
                        Console.WriteLine(convertMass(conv));
                    }
                    break;
                case "5":
                    
                    break;
                default:
                    Console.WriteLine("Incorrect input!!!\nPlease ONLY make use of numbers!");
                    break;
                
                
            }

        } while (input != "5");
        
        
        IDictionary<int, string> step = display.getProcedure();

        foreach (KeyValuePair<int, string> kvp in step)
        {
            
            Console.WriteLine("Step{0}: {1}", kvp.Key, kvp.Value);   
            
        }

    }


    public static string convertMass(string[] storage)
    {
        
        // Parse the input teaspoon value from the storage array
        double teaspoon = double.Parse(storage[0]);
        string outp = null;

        // Check if teaspoon is greater than or equal to 3 and the target unit is not "cup"
        if (teaspoon >= 3 && !storage[1].Equals("cup")) {
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
                outp = cup + " cups\n" + tablespoon.ToString() + " tablespoons\n" + teaspoon + " teaspoons";
                return outp;
            } else {
                // Construct the output string with tablespoons and teaspoons
                outp = tablespoon.ToString() + " tablespoons\n" + teaspoon + " teaspoons";
                return outp;
            }
        } else {
            // If teaspoon is less than 3 or the target unit is "cup", return the original teaspoon value with the target unit
            outp = teaspoon + storage[1];
            return outp;
        }
        
    }


    private static intDelegate warning = (int calories) =>
    {

        calWrng = +calories;

        if (calWrng > 300)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE CALORIES IN THIS RECIPE EXCEED 300!!!");
            Console.ForegroundColor = ConsoleColor.White;

        }

    };

}
    

