using UnityEngine;
using System.Collections;

public class TargetCounter : MonoBehaviour {

	public GUIText targetNum;
	private int targets = 0;
	GameObject Dog;

	// Use this for initialization
	void Start () {
		Dog = GameObject.Find ("WestDog3");
	}
	
	// Update is called once per frame
	void Update () {
		targets = Dog.GetComponent<WestDog> ().t;
		targetNum.text = "Target : " + targets.ToString ();
	}
}
