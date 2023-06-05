namespace ST10057222_PROG2A_NEFALE;

public class Ingredient
{
    
    // Declare array variables as fields.
    private String Name;
    private double Quantity;
    private string unitMeasurment;
    
    // This is a constructor that takes no arguments.
    public Ingredient()
    {
        
        
        
    }

    // This is a constructor that takes several arguments.
    public Ingredient(String iName, double iQuant, string unitMes)
    {

        this.Name = iName;
        this.Quantity = iQuant;
        this.unitMeasurment = unitMes;


    }
    
    
    // This method sets the name field of the recipe.
    public void setName(string incoming) 
    {
    
        // Assign the input to the name field of the object.
        Name = incoming;
        
    }

    // This method gets the values stored in Name.
    public string getName() 
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
    public double getQuantity() 
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
    public string getMeasurment() 
    {
        
        // Return the name field of the object.
        return unitMeasurment;
            
    }
    
   
    public static string toString() 
    {

        return null;

    }
    
}