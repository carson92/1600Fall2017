using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class saveCheckpoint : MonoBehaviour {

	public Transform player;
	Vector3 checkPoint;
	string[] playerPrefsTitles = {"CheckpointX", "CheckpointY", "CheckpointZ"};
	 
	void OnTriggerEnter()
	{
		checkPoint = transform.position;
			for (int i = 0; i < playerPrefsTitles.Length; i++)
			{
				PlayerPrefs.SetFloat(playerPrefsTitles[i], checkPoint[i]);
			}}
	void start()	{
		for (int i = 0; i < playerPrefsTitles.Length; i++)
			{
					checkPoint[i] = PlayerPrefs.GetFloat(playerPrefsTitles[i]);
			}
		player.position = checkPoint;
	}	
			
			
			
}