namespace ST10057222_PROG2A_NEFALE;

public class Ingredient
{
    
    // Declare array variables as fields.
    private static String Name;
    private static double Quantity;
    private static string unitMeasurment;
    private static string foodGroup;
    
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
    
    
    // This method sets the name field.
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
    
    // This method sets the quantity field.
    public void setQuantity(double incoming) 
    {
    
        // Assign the input to the name field of the object.
        Quantity = incoming;
        
    }

    // This method gets the values stored in quantity.
    public double getQuantity() 
    {
        
        // Return the name field of the object.
        return Quantity;
            
    }

    // This method sets the measurement field.
    public void setMeasurment(string incoming) 
    {
    
        // Assign the input to the measurment field of the object.
        unitMeasurment = incoming;
        
    }

    // This method gets the values stored in measurement.
    public string getMeasurment() 
    {
        
        // Return the measurment field of the object.
        return unitMeasurment;
            
    }
    
    public void setFoodGroup() 
    {
    
        // Assign the input to the foodgroup field of the object.

        bool flag = false;
        do
        {

            Console.WriteLine("Please select a food group:\n1. Starchy foods\n2. Vegetables and fruits\n3. Dry beans, peas, lentils and soya\n4. Chicken, fish, meat and eggs\n5. Milk and dairy products\n6. Fats and oil\n7. Water");
            string input = Console.ReadLine();

            switch (input)
            {

                case "1":
                    foodGroup = "Starchy foods";
                    flag = true;
                    break;
                case "2":
                    foodGroup = "Vegetables and fruits";
                    flag = true;
                    break;
                case "3":
                    foodGroup = "Dry beans, peas, lentils and soya";
                    flag = true;
                    break;
                case "4":
                    foodGroup = "Chicken, fish, meat and eggs";
                    flag = true;
                    break;
                case "5":
                    foodGroup = "Milk and dairy products";
                    flag = true;
                    break;
                case "6":
                    foodGroup = "Fats and oil";
                    flag = true;
                    break;
                case "7":
                    foodGroup = "Water";
                    flag = true;
                    break;
                default:
                    Console.WriteLine("Incorrect selection/input.\nPLease make use of numbers only");
                    break;
                    
            }
            
        } while (flag == false);
        
        
    }

    // This method gets the values stored in foodgroup.
    public string getFoodGroup() 
    {
        
        // Return the foodgroup field of the object.
        return foodGroup;
            
    }
   
    public string toString() 
    {

        return "\nIngredient name: " + Name + "\nQuantity: " + Quantity + " " + unitMeasurment;

    }
    
}