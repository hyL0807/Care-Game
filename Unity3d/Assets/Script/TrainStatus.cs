using UnityEngine;
using System.Collections;

public class TrainStatus : MonoBehaviour {

	public Sprite[] img;
	SpriteRenderer spriteRenderer;

	int hp = 3;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(hp != Train.hp)
        {
			hp = Train.hp;
			spriteRenderer.sprite = img[hp];
        }
		
	}
}
