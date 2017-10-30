using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {
	public Transform attachObject;
	public GameObject assetArt;
	public GameObject moreStuff;
	void OnTriggerEnter()
	{
		transform.parent = attachObject;
		transform.localPosition = Vector3.zero;
		transform.localRotation = Quaternion.identity;
		GetComponent<BoxCollider>().enabled = false;
	}

}
