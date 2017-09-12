using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteration : MonoBehaviour {

	// what game object im going to spawn
	public GameObject go;

	// Use this for initialization
	void Start () {

		// for loop
		// has 4 components:
		// 1st: int i = 0;, create a variable, initialize its value
		// 2nd: the condition, is i less than 10?
		// 3rd: execute the code in between the curly bracks if 2 is true
		// 4th: increment the index number
		for (int i = 0; i < 10; i++) {

			// creating a new vector3 based on the index number
			Vector3 myVec = new Vector3(i-5,2,0);

			// create the object
			Instantiate (go, myVec, Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}