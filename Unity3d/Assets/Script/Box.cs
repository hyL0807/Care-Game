using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

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

			if (hit.collider != null && hit.collider.name == "Box")
			{
				transform.Translate(new Vector2(0.1f, 0));

				if (spriteRenderer.sprite == img[0])
					spriteRenderer.sprite = img[1];
				else spriteRenderer.sprite = img[0];
			}

		}
	}
}
