using UnityEngine;
using System.Collections;

public class OnMouse : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		spriteRenderer.sprite = img[1];
	}

	void OnMouseExit(){
		spriteRenderer.sprite = img[0];
	}
}
