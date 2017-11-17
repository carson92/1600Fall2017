using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hillarySound : MonoBehaviour {

	public AudioSource soundSource;
	public AudioClip no;
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("banana")){
			soundSource.PlayOneShot(no);
		}
	}
}
