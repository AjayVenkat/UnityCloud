using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AcelBottle : MonoBehaviour {

	public Text xT;
	public Text zT;
	public Text yT;

	public bool usingCur;

	Vector3 startPosBottle;
	Vector3 startRot;

	public float power;
	public float multiplier;
	public float maxPower;

	public Vector3 startPos;
	public Vector3 endPos;
	public Vector3 direction;

	public Rigidbody rBody;

	public Transform startPlace;


	bool hasStarted;
	// Use this for initialization
	void Start () {
	
	}

	public void Reset() {
		rBody.isKinematic = true;
		transform.position = startPosBottle;
		transform.eulerAngles = startRot;
		power = maxPower;
		//maxPower = rBody.mass * 400;
		multiplier = 1;

	}
	
	// Update is called once per frame
	void Update () {
	
		xT.text = Input.acceleration.x.ToString ();
		yT.text = Input.acceleration.y.ToString ();
		zT.text = Input.acceleration.z.ToString ();

		if (usingCur == true) {

			if (hasStarted == false) {

				if (Input.acceleration.x >= 0 || Input.acceleration.y >= 0 || Input.acceleration.z >= 0) {

					hasStarted = true;
					startPos = Input.acceleration;

				}


			} else if (hasStarted == true) {

				if (Input.acceleration.x >= 0 || Input.acceleration.y >= 0 || Input.acceleration.z >= 0) {

					multiplier += 5;
					power -= Time.deltaTime * multiplier;

				}


				if (Input.acceleration.x >= 1 || Input.acceleration.y >= 1 || Input.acceleration.z >= 1) {

					endPos = Input.acceleration;
					endPos.y = endPos.y * -1;
					endPos.x = endPos.x * -1;
					Vector3 dir = startPos - endPos;

					dir.x = 0;
					dir.Normalize ();


					direction = dir;

					rBody.AddForceAtPosition (dir * power, startPlace.position);
					rBody.AddForceAtPosition (Vector3.up * power, startPlace.position);


				}
					
			}




		}



	}
}
