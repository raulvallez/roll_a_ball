using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//The reference to the ball (Player Object)
	public GameObject player;

	//Distance between the camera and the ball (Player Object)
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//Offset = vector with the distance between the camera and the ball (Player Object)
		offset = transform.position - player.transform.position;
	}
	
	// It's like Update (is called once per frame), but it is guaranteed to run after all items have been processed in Update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
