using UnityEngine;
using System.Collections;

public class BoneStatus : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	private GameObject dog;

	int bones = 3;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		dog = GameObject.Find ("WestDog3");
	}
	
	// Update is called once per frame
	void Update () {
		if (bones != dog.GetComponent<WestDog>().b)
		{
			bones = dog.GetComponent<WestDog>().b;
			spriteRenderer.sprite = img[bones];
		}

	}
}
