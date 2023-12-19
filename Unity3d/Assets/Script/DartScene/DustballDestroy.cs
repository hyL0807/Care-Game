using UnityEngine;
using System.Collections;

public class DustballDestroy : MonoBehaviour {

	public float removeTime = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject != null)
			Destroy (gameObject, removeTime);
	}
}
