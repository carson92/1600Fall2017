using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour {

	public Text input;
	public bool canPlayGame = false;
	public string password = "G@mepl@y";
	public string password2 = "carsonscool";
	
	void Update () {
		if(input.text == password) {
			print("You know the password");
			canPlayGame = true;
		} 
		
		else {
			print("Incorrect password");
		}

		if(canPlayGame) {
			print("Playing Game");
		}

		else {
			print("Cant play yet, enter a correct password.");
		}

		if(input.text == password2) {
			print("You got the second password.");
		}

		else {
			print("You are obviously not the user. Go away.")
		}

		}
}
