using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float myVariable;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();


	}
	
	// Update is called once per frame
	void Update () {

		float MoveHorizontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (MoveHorizontal, 0.0f, MoveVertical);

		rb.AddForce(movement * speed);
	}
}
