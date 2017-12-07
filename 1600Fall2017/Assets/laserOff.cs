using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserOff : MonoBehaviour {
	public GameObject laser;

	void OnbTriggerEnter (Collider other) {
		if(other.CompareTag ("laseroff")){
			laser.SetActive(false);
		}

	}
}
