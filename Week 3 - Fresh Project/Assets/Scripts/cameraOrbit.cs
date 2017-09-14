using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraOrbit : MonoBehaviour {

	// Use this for initialization

	public Vector3 myCameraRotation;
	public Vector3 myCameraTranslate;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (myCameraTranslate * Time.deltaTime);
		transform.Rotate (myCameraRotation * Time.deltaTime);
	}
}
