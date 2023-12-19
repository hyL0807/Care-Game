using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	public float rayDistance = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{

			Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

			if (hit.collider != null && hit.collider.tag == "Target")
			{
				hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite = img[0];
				Destroy(hit.transform.gameObject,1); //destroy after 1sec
			}

		}
	}
}
