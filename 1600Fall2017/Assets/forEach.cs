//A foreach loop is a loop that can be carried out multiple times. The foreach loop is the easiest to make it so that it wont error, but it is also limited in some ways. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forEach : MonoBehaviour {

	
	void Update () {
		 string[] pets = { "dog", "cat", "bird" };

        foreach (string value in pets)
        {
            print("value");
		
	}
}
}
