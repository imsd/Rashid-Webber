using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushing : MonoBehaviour {

	public int moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown("space"))
			transform.Translate(0,0,moveSpeed * Time.deltaTime);
	}
}
