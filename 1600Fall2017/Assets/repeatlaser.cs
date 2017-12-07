using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatlaser : MonoBehaviour {
	public GameObject laser;
	public float repeatTime = 1f;
	public GameObject spawnPoint;
	void Start(){
		InvokeRepeating("RepeatLaser", repeatTime, repeatTime);
	}
	void RepeatLaser(){
		GameObject.Instantiate(laser);
		laser.transform.position = spawnPoint.transform.position;
			}
}
