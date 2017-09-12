using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {

	// Use this for initialization
	public Vector3 	myRotation;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
