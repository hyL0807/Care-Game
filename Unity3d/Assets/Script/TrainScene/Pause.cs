using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject Popup;
	public GameObject Finish;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Popup.gameObject.activeSelf == true)
		{
			Time.timeScale = 0.0f;
		}
		else if(Finish.gameObject.activeSelf == true)
		{
			Time.timeScale = 0.0f;
		}

		else
		{
			Time.timeScale = 1.0f;
		}

	}
}
