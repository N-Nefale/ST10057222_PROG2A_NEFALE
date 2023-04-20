class RecipeBook
{


    public static void Main()
    {

        /*Get the user to make a selection from the options provided below
            * Menu:
            *      1.New recipe
            *      2.View recipe
            *      3.Exit
            * 
            */

        string input = null;
        do
        {

            Console.WriteLine("Menu:\r\n         1* New recipe\r\n         2* View recipe\r\n         3* Clear Data\\r\\n         3* Exit");
            input = Console.ReadLine();

            if (input.Equals("1"))
            {

                //newRecipe();

            }
            else
            if (input.Equals("2"))
            {

                //viewRecipe();

            }
            else
            if (input.Equals("3"))
            {

                //clearData();

            }
            else
            {

                Console.WriteLine("\nINCORRECT SELECTION!!!!!\n");
            
            }

        } while (input != "4");


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

        Console.WriteLine("New recipe:\r\n Please enter the name of the recipe:");
        string rName = Console.ReadLine();
        Console.WriteLine("");


        Console.WriteLine("\r         How many ingredients are needed for this recipe:");
        int numOfIngredients = int.Parse(Console.ReadLine());

        String[] ingrNames = new string[numOfIngredients];
        double[] ingrQuantity = new double[numOfIngredients];
        String[] ingrUntsOfMeasuremnt = new string[numOfIngredients];

        for (int i = 0; 1 < numOfIngredients; i++)
        {

            Console.WriteLine("Please enter ingredient name:");
            ingrNames[i] = Console.ReadLine();

            Console.WriteLine("Please enter how much ingredient of this ingerdient is needed:");
            ingrQuantity[i] = double.Parse(Console.ReadLine());


            Console.WriteLine("Please select a unit of measurement for this ingredient:\r\n 1.Milligrams(mg)\r\n 2.Grams(g)\r\n 3.");
            //ingrUntsOfMeasuremnt[i]

        }



        Console.WriteLine("Please enter the number of step in this recipe");
        int numOfSteps = int.Parse(Console.ReadLine());
        string[] steps = new string[numOfSteps];
        
        int stepProg = 1;

        for (int b = 0; b < numOfSteps; b++)
        {


            Console.WriteLine("Please enter step " + stepProg + " of the recipe: ");
            steps[b] = Console.ReadLine();

            b++;
            stepProg++;

        }


        Console.ReadKey();

    }







}