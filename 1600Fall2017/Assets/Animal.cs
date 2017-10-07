//Void functions are used so that you can make funtcions operate while they are still in classes so they are only visible to the code. For example in this void function we are making a loop that prints what the fox is eating and how many even though it is just in the void function classes.  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public string[] foxFood = {"Bananas", "Apples", "Grapes", "Chicken", "turkey", "Cake"};
public int[] foodCount = {10, 2, 30, 1, 2, 1};
public string[] weapons = {"Gun", "Knife", "Rocket Launcher", "Sniper", "Pistol"};
public int[] weaponCount = {2, 3, 1, 1, 1};

public virtual void Start () {
	Die();
	Eat("Bananas", 10);
	Eat("Apples", 2);
	Eat("Grapes", 30);
	Eat("Chicken", 1);
	Eat("Cake", 1);
	Use("Gun", 2);
	Use("Knife", 3);
	Use("Rocket Launcher", 1);
	Use("Sniper", 1);
	Use("Pistol", 1);


	for (int i = 0; i < foxFood.Length; i++)
	{
		Eat(foxFood[i], foodCount[i]);
	}
	for (int i = 0; i < weapons.Length; i++)
	{
		Use(weapons[i], weaponCount[i]);
	}
}
void Die() {
	print(this.name + " Dies");
}
void Eat(string food, int amount) {
	print(this.name + " likes to eat " + food);
	print(this.name + " ate " + amount);

}
void Use(string weapons, int amount) {
	print(this.name + " likes to use " + weapons);
	print(this.name + " used " + amount);
}
void Sleep(){
	print(this.name + " sleeps");
}
}
