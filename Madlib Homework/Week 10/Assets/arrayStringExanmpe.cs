using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayStringExanmpe : MonoBehaviour {


	public string [] names;
	public string [] places;
	public string [] verbs;
	public string [] places2;
	public string [] items;
//	public string [] places;
//	public string [] places;
//	public string [] places;
//	public string [] places;
//	public string [] places;

	// public string [] Not array;

	// Use this for initialization

	void Start () {
//		for(int i = 0; i < names.Length; i++){
//		Debug.Log (names[1]);
//	}

//		Debug.Log (Random.Range (0f, 3f));

		int randNoun = Random.Range (0, names.Length);
		int randPlaces = Random.Range (0, places.Length);
//		Debug.Log(names [rando]);

		string line1 = "One day, " + names 
		[randNoun] + " went to " + places[randPlaces] + "." 
		+" " names[randNoun] +  " is here to get"
		

		Debug.Log (line1);

	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
