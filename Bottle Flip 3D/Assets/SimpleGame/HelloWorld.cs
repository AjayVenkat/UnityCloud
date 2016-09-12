using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {

	public Text helloWorldText;
	public string name;
	// Use this for initialization
	void Start () {
		helloWorldText.text = "Hello: " + name;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
