using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {

	public GameObject speed;

	void Start()
	{
		speed.SetActive(false);
	}
	void OnTriggerEnter(Collider other)
	{
		speed.SetActive(true);
	}
}
