using UnityEngine;
using System.Collections;

public class WestDog : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		pos.y = gameObject.transform.position.y;
		gameObject.transform.position = pos;
	}
}
