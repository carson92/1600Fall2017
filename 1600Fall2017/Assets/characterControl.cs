using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {
	public CharacterController characterController;
	public float gravity = 3f; 
	public Vector3 moveVector3;
	public float speed = 10;
	public float jumpForce = 50;
	
	void FixedUpdate () {
		moveVector3.y -= gravity * Time.deltaTime;
		if(characterController.isGrounded){
			if(Input.GetKey(KeyCode.Space)){
			moveVector3.y += jumpForce * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		
		characterController.Move(moveVector3);
		
	}
}
