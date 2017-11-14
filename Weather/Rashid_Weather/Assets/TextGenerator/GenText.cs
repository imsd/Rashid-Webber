using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenText : MonoBehaviour {

	public GameObject CharacterObject;
	public float CharacterSpacing = .2f;

	public Vector3 DropFrom;

	// this method will be called from another script (the twitter controller)
	// so we use public
	public void DropText (string TheText) {

		// for keeping track of the x position as we generate each new character
		float lastTextWidth = 0f;

		// go thru each character in the string
		for (int i = 0; i < TheText.Length; i++) {

			Vector3 xOffset = new Vector3 (lastTextWidth, 0, 0);

			// create an instance of text mesh
			GameObject NewCharacter = (GameObject)Instantiate (CharacterObject, transform.position + xOffset, Quaternion.identity);

			// put that instance's character 
			NewCharacter.GetComponent<TextMesh> ().text = TheText[i].ToString();

			// how wide is this particular character?
			Bounds textBounds = NewCharacter.GetComponent<Renderer>().bounds;

			// for positioning the offset of the next character
			lastTextWidth = Mathf.Abs(textBounds.max.x - transform.position.x) + .3f;
		

			// make the collider for this character equal to its size (not all text characters have the same size!)
			NewCharacter.GetComponent<BoxCollider> ().size = new Vector3 (Mathf.Abs(textBounds.max.x - textBounds.min.x), Mathf.Abs(textBounds.max.y - textBounds.min.y), .1f);
		
			NewCharacter.transform.Rotate (70, 0, 0);
		}
	}
}