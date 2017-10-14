//A returen will return the informstion to its caller. So it is referrencing an integer or some sort of information to a different place in the script. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returns : MonoBehaviour {
	void Main(string[]) {
		Console.WriteLine(returnString());
	}

	string returnString(int HotorNot)  {
		if (HotorNot < 6)
			return "You are not hot!";
		if (HotorNot >= 6)
			return "You are hot enough.";

	}
}
