using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject rulePopup;
	public GameObject finishPopup;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(rulePopup.gameObject.activeSelf == true)
		{
			Time.timeScale = 0.0f;
		}
		else if(finishPopup.gameObject.activeSelf == true)
		{
			Time.timeScale = 0.0f;
		}
		else
		{
			Time.timeScale = 1.0f;
		}

	}
}
