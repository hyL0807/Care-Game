﻿using UnityEngine;
using System.Collections;

public class DustballMove : MonoBehaviour {

	public float animSpeed = 1.0f;
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator.speed = animSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
