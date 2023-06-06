namespace ST10057222_PROG2A_NEFALE;

public class Ingredient
{
    
    // Declare array variables as fields.
    private static String Name;
    private static double Quantity;
    private static string unitMeasurment;
    
    // This is a constructor that takes no arguments.
    public Ingredient()
    {
        
        
        
    }

    // This is a constructor that takes several arguments.
    public Ingredient(String iName, double iQuant, string unitMes)
    {

        Name = iName;
        Quantity = iQuant;
        unitMeasurment = unitMes;
        
    }
    
    
    // This method sets the name field of the recipe.
    public void setName(string incoming) 
    {
    
        // Assign the input to the name field of the object.
        Name = incoming;
        
    }

    // This method gets the values stored in Name.
    public static string getName() 
    {
        
        // Return the name field of the object.
        return Name;
            
    }
    
    // This method sets the quantity field of the recipe.
    public void setQuantity(double incoming) 
    {
    
        // Assign the input to the name field of the object.
        Quantity = incoming;
        
    }

    // This method gets the values stored in Name.
    public static double getQuantity() 
    {
        
        // Return the name field of the object.
        return Quantity;
            
    }

    // This method sets the name field of the recipe.
    public void setMeasurment(string incoming) 
    {
    
        // Assign the input to the name field of the object.
        unitMeasurment = incoming;
        
    }

    // This method gets the values stored in Name.
    public static string getMeasurment() 
    {
        
        // Return the name field of the object.
        return unitMeasurment;
            
    }
    
   
    public static string toString() 
    {

        return "\nIngredient name: " + Name + "\nQuantity: " + Quantity + " " + unitMeasurment;

    }
    
}