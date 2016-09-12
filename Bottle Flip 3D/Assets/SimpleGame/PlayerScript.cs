  using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	//This is player speed
	public int playerSpeed;
	public int anotherSpeed;
	//This is players camera
	public Transform playerCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerSpeed < 0 || playerSpeed > 10) {
			print ("Player Speed is 0 or 2");
		} 
	}
}
