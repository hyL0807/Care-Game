using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

			if (hit.collider != null && hit.collider.name == "target")
			{
				spriteRenderer.sprite = img[0];
				Destroy(gameObject,1); //destroy after 3sec
			}

		}
	}
}
