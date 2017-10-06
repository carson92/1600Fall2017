// A for loop is a loop that will run the same code multiple times, but the for makes it act in a certain way. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoop : MonoBehaviour{
	int numEnemies = 3;
	int numCars = 3; 
	int numHouses = 3;
	int numPeople = 3; 
	int numGames = 3; 
	int numMoney = 3;
	int numMuggles = 3;
	int numHeroes = 3; 
	int numPhones = 3;
	int numPowerups = 3; 
	void start ()
	{
		for(int i = 0; i < numEnemies; i++)
	{
		print("Creating enemy number: " + i);
	}
		for(int i = 0; i < numCars; i++)
	{
		print("Creating car number: " + i);
	}
		for(int i = 0; i < numHouses; i++)
	{
		print("Creating house number: " + i);
	}
	for(int i = 0; i < numPeople; i++)
	{
		print("Creating person number: " + i);
	}	
		for(int i = 0; i < numGames; i++)
	{
		print("Creating game number: " + i);
	}
		for(int i = 0; i < numMoney; i++)
	{
		print("Creating dollar number: " + i);
	}
		for(int i = 0; i < numMuggles; i++)
	{
		print("Creating nonmagical number: " + i);
	}
		for(int i = 0; i < numHeroes; i++)
	{
		print("Creating hero number: " + i);
	}
		for(int i = 0; i < numPhones; i++)
	{
		print("Creating phone number: " + i);
	}
		for(int i = 0; i < numPowerups; i++)
	{
		print("Creating powerup number: " + i);
	}
	}
}
