using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whileloop : MonoBehaviour {

	public bool canPlay = true;
	public bool canJump = true;
	public bool canRun = true;
	public bool canFly = true; 
	public bool canLeap = true;
	public bool canEat = true;
	public bool canFart = true;
	public bool canDie = true;
	public bool canRoll = true;
	public bool canLive = true;

	void Start() {
		StartCoroutine(PlayGame());
		StartCoroutine(JumpCharacter());
		StartCoroutine(RunCharacter());
		StartCoroutine(FlyCharacter());
		StartCoroutine(LeapCharacter());
		StartCoroutine(CharacterEating());
		StartCoroutine(CharacterFarting());
		StartCoroutine(CharacterDying());
		StartCoroutine(CharacterRolling());
		StartCoroutine(CharacterLiving());

	}

	IEnumerator PlayGame () {
		
		while (canPlay) {
			print("Playing");
			yield return new WaitForSeconds(0.1f);
		}
		print("End Game");
	}
	IEnumerator JumpCharacter () {
		while (canJump) {
			print("Jumping");
			yield return new WaitForSeconds(0.1f);
		}
		print("Not Jumping");
	}
	IEnumerator RunCharacter () {
		while (canRun) {
			print("Running");
			yield return new WaitForSeconds(0.1f);
		}
		print("Not Running");
	}
	IEnumerator FlyCharacter () {
		while (canFly) {
			print("Flying");
			yield return new WaitForSeconds(0.1f);
		}
		print("Crashing");
	}
	IEnumerator LeapCharacter () {
		while (canLeap) {
			print("Leaping");
			yield return new WaitForSeconds(0.1f);
		}
		print("Falling");
	}
	IEnumerator CharacterEating () {
		while (canEat) {
			print("Eating");
			yield return new WaitForSeconds(0.1f);
		}
		print("Starving");
	}
	IEnumerator CharacterFarting () {
		while (canFart) {
			print("Farting");
			yield return new WaitForSeconds(0.1f);
		}
		print("Not Farting");
	}
	IEnumerator CharacterDying () {
		while (canDie) {
			print("Dying");
			yield return new WaitForSeconds(0.1f);
		}
		print("Living");
	}
	IEnumerator CharacterRolling () {
		while (canRoll) {
			print("Rolling");
			yield return new WaitForSeconds(0.1f);
		}
		print("Staying still");
	}
	IEnumerator CharacterLiving () {
		while (canLive) {
			print("Living");
			yield return new WaitForSeconds(0.1f);
		}
		print("Dead");
	}
}