using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriping : MonoBehaviour {

		public GameObject go;
		public GameObject go2;	// second type of game object to spawn

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

			if (Input.GetKeyDown("z")) {
				// create a physics cube when A key is pressed
				Instantiate (go, transform.position, Quaternion.identity);

				Debug.Log ("key down");
			}

			if (Input.GetKeyDown("space")) {
				// create a phys sphere when spacebar is hit
				Instantiate (go2, transform.position, Quaternion.identity);
			}

		}
	}