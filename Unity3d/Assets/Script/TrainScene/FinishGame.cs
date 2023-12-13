using UnityEngine;
using System.Collections;

public class FinishGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
			
			if (hit.collider != null && hit.collider.name == "FinishPopup")
			{
				Application.LoadLevel("main");
			}
		}
	}
}
