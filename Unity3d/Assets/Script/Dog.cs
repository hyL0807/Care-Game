using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(Screen.height);
		Debug.Log(Screen.width);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{

			Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

			if (hit.collider != null && hit.collider.name == "dog")
			{
				transform.Translate(new Vector2(0.3f, 0));

			}

		}
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		Debug.Log(other.gameObject.name);
    }
}
