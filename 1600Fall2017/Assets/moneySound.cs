using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySound : MonoBehaviour {

	public AudioSource soundSource;
	public AudioClip imReallyRich;
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Health")){
			soundSource.PlayOneShot(imReallyRich);
		}
	}}
