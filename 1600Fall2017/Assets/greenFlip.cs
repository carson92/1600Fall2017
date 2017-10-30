using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenFlip : MonoBehaviour {

	Quaternion myRotate;
	Vector3 rotValue;
	// Use this for initialization

	void Start () {
		MoveInput.MoveAction += Flip;
	}

    private void Flip(float obj)
    {
		if(obj > 0 )
			rotValue.y = 330;

		if(obj < 0)
			rotValue.y = 30;

		myRotate.eulerAngles = rotValue;
        transform.rotation = myRotate; 
    }
}
