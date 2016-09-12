using UnityEngine;
using System.Collections;

public class AcelOrBottle : MonoBehaviour {

	public bool useAcel;


	void Start() {

		if (useAcel == true) {

			useAcel = true;
			GetComponent<Bottle> ().enabled = false;
			GetComponent<AcelBottle> ().enabled = true;
			GetComponent<AcelBottle> ().usingCur = true;
			GetComponent<Bottle> ().usingCur = false;


		} else {

			useAcel = false;
			GetComponent<Bottle> ().enabled = true;
			GetComponent<AcelBottle> ().enabled = false;
			GetComponent<AcelBottle> ().usingCur = false;
			GetComponent<Bottle> ().usingCur = true;
		}


	}

	public void Switch() {

		if (useAcel == false) {

			useAcel = true;
			GetComponent<Bottle> ().enabled = false;
			GetComponent<AcelBottle> ().enabled = true;
			GetComponent<AcelBottle> ().usingCur = true;
			GetComponent<Bottle> ().usingCur = false;

		} else {

			useAcel = false;
			GetComponent<Bottle> ().enabled = true;
			GetComponent<AcelBottle> ().enabled = false;
			GetComponent<AcelBottle> ().usingCur = false;
			GetComponent<Bottle> ().usingCur = true;
		}

	}

}
