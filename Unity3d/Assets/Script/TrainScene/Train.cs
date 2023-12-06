﻿using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

	float lPosX = 0f;
	float rPosX = 0f;
	float xScreenHalfSize;
	float yScreenHalfSize;

	public static int hp = 3;
	public static int coin = 0;

	// Use this for initialization
	void Start () {

		//player position setting
		transform.position = new Vector2(-7.7f,-1.3f);

		//camera height, width
		yScreenHalfSize = Camera.main.orthographicSize;
		xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;

		lPosX = -xScreenHalfSize;
		rPosX = xScreenHalfSize;
	}

	void getDamage()
	{
		hp -= 1;
		if (hp < 0) hp = 0;
	}

	void getCoin()
    {
		coin += 1;
    }

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey("d"))
        {
			if(transform.position.x < rPosX)
            {
				transform.Translate(new Vector2(0.5f, 0));
            }
		}
        if (Input.GetKey("a"))
        {
			if (transform.position.x > lPosX)
			{
				transform.Translate(new Vector2(-0.5f, 0));
			}
		}
        if (Input.GetKey("w"))
        {
			if(transform.position.y < 0.7)
            {
				transform.Translate(new Vector2(0, 1.0f));
            }
        }
		if (Input.GetKey("s"))
		{
			if (transform.position.y > -3.4)
			{
				transform.Translate(new Vector2(0, -1.0f));
			}
		}

	}

	
}