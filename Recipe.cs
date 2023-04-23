using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10057222_PROG2A_NEFALE
{


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
