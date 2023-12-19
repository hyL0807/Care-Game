using UnityEngine;
using System.Collections;

public class BackgroundDust : MonoBehaviour {

	public GameObject dust;
	public float waitTime = 1.0f;

	private GameObject ball;
	
	void DustballMove()
	{
		Instantiate(dust, dust.transform.position ,Quaternion.identity);
	}
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("DustballMove", waitTime, waitTime);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
