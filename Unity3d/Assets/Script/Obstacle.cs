﻿using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	float lPosX = 0f;
	float rPosX = 0f;
	float xScreenHalfSize;
	float yScreenHalfSize;

	// Use this for initialization
	void Start () {
		//camera height, width
		yScreenHalfSize = Camera.main.orthographicSize;
		xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;

		lPosX = -xScreenHalfSize;
		rPosX = xScreenHalfSize;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(-0.1f, 0));

		if (transform.position.x < lPosX) Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.name == "Train")
        {
			other.transform.SendMessage("getDamage");
			Destroy(gameObject);
        }
    }
}
