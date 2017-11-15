using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {

	public CharacterController characterController;
	public float gravity = 3f; 
	public Vector3 moveVector3;
	private  float speed = 10;
	public float jumpForce = 10;
	public int time;
	
	void FixedUpdate () {
		moveVector3.y -= gravity * Time.deltaTime;
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		  
		if(characterController.isGrounded){
			if(Input.GetKey(KeyCode.Space)){
			moveVector3.y += jumpForce * Time.deltaTime;
			}
		}
		
		characterController.Move(moveVector3);
		
	}

void OnTriggerEnter(Collider other)
{
	if(other.CompareTag("speed")){
		speed = speed + 15;
		Invoke("Timer", 3);
	}
}

void Timer () {
	speed = speed -15;
}
} 
