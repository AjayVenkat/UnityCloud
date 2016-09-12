using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour {

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

	void Start() {
		if (usingCur == true) {
			startPosBottle = transform.position;
			startRot = transform.eulerAngles;
		}
		//maxPower = rBody.mass * 400;
	}

	void Update() {
		if (usingCur == true) {
			if (Input.GetMouseButtonDown (1)) {
				rBody.isKinematic = true;
				transform.position = startPosBottle;
				transform.eulerAngles = startRot;
				//maxPower = rBody.mass * 400;
			}
		}

	}

	public void Reset() {
		if (usingCur == true) {
			rBody.isKinematic = true;
			transform.position = startPosBottle;
			transform.eulerAngles = startRot;
		}
	}


	void OnMouseDown() {
		if (usingCur == true) {
			startPos = Camera.main.WorldToScreenPoint (Input.mousePosition);
			startPos.y = startPos.y * -1;
			startPos.x = startPos.x * -1;
			power = maxPower;
			//maxPower = rBody.mass * 400;
			multiplier = 1;
		}
	}

	void OnMouseDrag() {
		if (usingCur == true) {
			multiplier += 5;
			power -= Time.deltaTime * multiplier;
		}
	}

	void OnMouseUp() {
		if (usingCur == true) {
			rBody.isKinematic = false;
			endPos = Camera.main.WorldToScreenPoint (Input.mousePosition);
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
