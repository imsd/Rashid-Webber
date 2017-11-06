using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayStringExanmpe : MonoBehaviour {


	public string [] names;
	public string [] places;
	public string [] verbs;
	public string [] places2;
	public string [] items;
	public string [] names2;
//	public string [] verbs;
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
		int randPlaces2 = Random.Range (0, places2.Length);
		int randItems = Random.Range (0, items.Length);
		int randNames2 = Random.Range (0, names2.Length);
		int randVerbs = Random.Range (0, verbs.Length);

//		Debug.Log(names [rando]);

		string line1 = "One day, " + names [randNoun] + " went to " + places [randPlaces] + "."
		               + " " + names [randNoun] + " is here to get a/an " + items [randItems] + "." + " " + names [randNoun] + " is greeted by " + names2 [randNames2] + " as he walks by."
			+ " After chatting for awhile , they both decided to go " + verbs [randVerbs] + " at " + places2[randPlaces2] + ".";
			;
		

		Debug.Log (line1);

	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
