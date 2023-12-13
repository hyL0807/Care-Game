using UnityEngine;
using System.Collections;

public class HealthStatus : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	GameObject train;

	int hp = 3;

	// Use this for initialization
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		train = GameObject.Find("Train");
	}

	// Update is called once per frame
	void Update()
	{
		if (hp != train.GetComponent<Train>().hp)
		{
			hp = train.GetComponent<Train>().hp;
			spriteRenderer.sprite = img[hp];
		}

	}
}
