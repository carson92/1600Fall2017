using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedMove : MonoBehaviour {
public float speed;
	void Update () {
		if(gameObject == true)
transform.Translate(Vector3.forward * Time.deltaTime * speed);

	}
}
