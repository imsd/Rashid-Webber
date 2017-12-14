using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Main : MonoBehaviour {

	Animator animator;
	public bool walking = true;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("Walking",-1f);
//		animator.SetFloat ();
	}
}
