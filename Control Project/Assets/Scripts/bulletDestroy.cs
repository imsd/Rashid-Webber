﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour {
	public float  timer;
	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > 5 ){
			Destroy (this.gameObject);
		}
	}


}
