
namespace ST10057222_PROG2A_NEFALE;

class Recipe 
{

    // Declare array variables as fields.
    public string rName;
    public List<Ingredient> rIngredients;
    public IDictionary<int, string> rSteps;
        
    // This is a constructor that takes no arguments.
    public Recipe() 
    {
        
        // There is no code inside this constructor.
    
    }

    // This is a constructor that takes several arguments.
    public Recipe(string n, List<Ingredient> i,IDictionary<int, string> s) 
    {
            
        // Assign the input arguments to the corresponding fields of the object.
        rName = n;
        rIngredients = i;
        rSteps = s;

    }

    
    
    
    
    // assigns the incoming variable to its corrisponding field
    public void setName(string incoming)
    {

        rName = incoming;

    }
    
    //retrieves the data stored in the feild and returns it to where its beiign requested
    public string getName()
    {
        
        return rName; 
        
    }
    
    
    // assigns the incoming variable to its corrisponding field
    public void setIngredients(List<Ingredient> incoming)
    {

        rIngredients = incoming;

    }
    
    //retrieves the data stored in the feild and returns it to where its beiign requested
    public List<Ingredient>  getIngredients()
    {
        
        return rIngredients; 
        
    }
    
    
    // assigns the incoming variable to its corrisponding field
    public void setSteps(IDictionary<int, string> incoming)
    {

        rSteps = incoming;

    }
    
    //retrieves the data stored in the feild and returns it to where its beiign requested
    public IDictionary<int, string>  getSteps()
    {
        
        return rSteps; 
        
    }

    
    
    
    
    
    public static string toString() 
    {

        return null;

    }

}
