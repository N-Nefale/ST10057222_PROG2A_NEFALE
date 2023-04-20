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