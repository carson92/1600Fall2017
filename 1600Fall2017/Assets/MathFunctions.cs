//When functions are given parameters it makes them so that they need a certain thing to be true or to work. For example in the first one here, the password needs to be "deja" wo work.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {

	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword("deja");
		myAge = ReturnAge("18");
	}
	
	public int myScore = 100;
	public int health;
	public int ammo;
	public string myPassword = "StupidStuff";
	int ReturnNum (int _num, int _num2) {
		return _num + _num2;
	}

	int ReturnZero () {
		return 1 + 1;
	}

	string ReturnPassword (string _login) {
		if(_login == "deja") {
		return "Password";
		} else{
			return "Incorrect";
		}
	}
	float ReturnAge (float _login) {
		if(_login >= "18") {
			return "You are allowed";
		} else {
			return "No way Jose";
		}
	}

}