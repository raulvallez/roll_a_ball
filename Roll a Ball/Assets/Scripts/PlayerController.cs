using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;

	public Text countText;

	public Text winText;

	public Rigidbody rb;

	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Just called before physics calculations
	void FixedUpdate () 
	{
		//Capturamos el movimiento horizontal desde un keyboard o joystick
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//Capturamos el movimiento vertical desde un keyboard o joystick
		float moveVertical = Input.GetAxis ("Vertical");

		//Determinamos la fuerza del movimiento de la bola (x,y,z)
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//Vector3
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText ();
		}
	}

	void setCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!!!";
		}
	}
}
