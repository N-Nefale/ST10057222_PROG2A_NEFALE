
namespace ST10057222_PROG2A_NEFALE;

class Recipe
{

    // Declare array variables as fields.
    private static string Name;
    private static List<Ingredient> listOfIngredient = new List<Ingredient>();
    private static IDictionary<int, string> procedures = new Dictionary<int, string>();
    
    // This is a constructor that takes no arguments.
    public Recipe()
    {



    }

    // This is a constructor that takes several arguments.
    public Recipe(string rName, List<Ingredient> rIngredients, IDictionary<int, string> rProcedure)
    {

        // Assign the input arguments to the corresponding fields of the object.
        Name = rName;
        listOfIngredient = rIngredients;
        procedures = rProcedure;


    }


    // This method sets the recipe name.
    public void setRecipeName(string incoming)
    {

        // Assign the input string to the recipeName field of the object.
        Name = incoming;

    }

    // This method gets the recipe name.
    public string getRecipeName()
    {

        // Return the Name field of the object.
        return Name;
    }

    // This method sets the first array of the recipe.
    public void setlistOfIngredient(List<Ingredient> incoming)
    {

        // Assign the input array to the listOfIngredient field of the object.
        listOfIngredient = incoming;

    }

    // This method gets the first array of the recipe.
    public List<Ingredient> getlistOfIngredient()
    {

        // Return the listOfIngredient field of the object.
        return listOfIngredient;

    }

    // This method sets the second array of the recipe.
    public void setProcedures(IDictionary<int, string> incoming)
    {

        // Assign the input array to the procedures field of the object.
        procedures = incoming;

    }

    // This method gets the second array of the recipe.
    public IDictionary<int, string> getProcedure()
    {

        // Return the procedures field of the object.
        return procedures;

    }


    public string toString()
    {
        
        return "\nRecipe name: " + Name + "\nIngerients:\n" + listOfIngredient.ToString() + "\nSteps:\n" + procedures.ToString();

    }


}