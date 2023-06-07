namespace ST10057222_PROG2A_NEFALE;

public class Ingredient
{
    
    // Declare array variables as fields.
    private string Name;
    private double Quantity;
    private string unitMeasurment;
    private int calories;
    private string foodGroup;
    
    // This is a constructor that takes no arguments.
    public Ingredient()
    {
        
        
        
    }

    // This is a constructor that takes several arguments.
    public Ingredient(String n, double q, string u, int c,string f)
    {

        this.Name = n;
        this.Quantity = q;
        this.unitMeasurment = u;
        this.calories = c;
        this.foodGroup = f;


    }
    
    
    
    
    
    
    // This method sets the name field of the recipe.
    public void setName(string incoming) 
    {
    
        Name = incoming;
        
    }

    // This method gets the values stored in Name.
    public string getName() 
    {
        
        return Name;
            
    }
    
    // This method sets the quantity field of the recipe.
    public void setQuantity(double incoming) 
    {
    
        Quantity = incoming;
        
    }

    // This method gets the values stored in quantity.
    public double getQuantity() 
    {
        
        return Quantity;
            
    }

    // This method sets the unit field of the recipe.
    public void setMeasurment(string incoming) 
    {
    
        unitMeasurment = incoming;
        
    }

    // This method gets the values stored in unit.
    public string getMeasurment() 
    {
        
        return unitMeasurment;
            
    }
    
    
    
    // This method sets the unit field of the recipe.
    public void setCalories(int incoming) 
    {
    
        calories = incoming;
        
    }

    // This method gets the values stored in unit.
    public int getCalories() 
    {
        
        return calories;
            
    }
    
   
    // This method sets the unit field of the recipe.
    public void setFoodgroup(string incoming) 
    {
    
        foodGroup = incoming;
        
    }

    // This method gets the values stored in unit.
    public string getFoodgroup() 
    {
        
        return foodGroup;
            
    }
    
    
    
    
    
    
    
    
    
    
    
    public static string toString() 
    {

        return null;

    }
    
}