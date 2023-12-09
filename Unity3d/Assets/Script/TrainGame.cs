using UnityEngine;
using System.Collections;

public class TrainGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("train click");
			Application.LoadLevel("train");
		}
	}
	
}
