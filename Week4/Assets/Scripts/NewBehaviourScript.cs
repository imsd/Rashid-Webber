using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float multiplier = 10f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// take in input from keyboard and multiply (scale up)
		float rotationX = Input.GetAxis("Horizontal") * multiplier;

		// same for up/down
		float rotationY = Input.GetAxis("Vertical") * multiplier;

		// put that number into a vec3 so we can work with it
		Vector3 v3 = new Vector3 (rotationX, rotationY, 0);

		// rotate!
		transform.Rotate (v3);

	}
}