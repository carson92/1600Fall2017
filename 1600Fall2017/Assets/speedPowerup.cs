using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedPowerup : MonoBehaviour {
public float speed;
private int time;
public float seconds;
private bool isCounting;
public AudioSource SoundSource;
public AudioClip speedSound;
	void Update() {
		if(isCounting){
			seconds -= Time.deltaTime;
		}
		if(seconds <= 0){
			isCounting = false;
			time = time - 1;
			speed = speed - 5;
			seconds = seconds + 10;
		}
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("speed")){
			other.gameObject.SetActive(false);
			time = time + 1;
			speed = speed + 5;
			isCounting = true;
		}
	}
}
