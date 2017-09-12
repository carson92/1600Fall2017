using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour {

	
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    float blackCoffee = 75.0f;
    float sweetCoffee = 50.0f; 
    float milkCoffee = 25.0f;
    float Coffee= 50.0f;
    float grossCoffee = 10.0f; 

    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        coffeeTemperature -= Time.deltaTime * 5f;

        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        blackCoffee -= Time.deltaTime * 5f;
    }
    
    
    void TemperatureTest ()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }

        if(sweetCoffee > blackCoffee)
        {
            print("Coffee is too black, spit that right out.");
        }

        else if(sweetCoffee < milkCoffee)
        {
            print("Coffee is too sweet, give it to a girl.");
        }

        else
        {
            print("Coffee is just right, drink up son.");
        }

        if(Coffee > grossCoffee)
        {
            print("This coffee is good enough. Drink it.");
        }

        if(Coffee < grossCoffee)
        {
            print("This is not worth your time. Throw away immediately");
        }
    
    }
}
