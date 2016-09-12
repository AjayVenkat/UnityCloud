using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {
//Quick reset for testing
	public GameObject bottle;

	// Use this for initialization
	void OnMouseDown() {
		bottle.GetComponent<Bottle> ().Reset ();
	}

}
