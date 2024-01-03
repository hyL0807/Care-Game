using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public GUIText timeText;
	public GUIText finishtimeText;

	public float time = 0.00f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		timeText.text = "Time : " + time.ToString("N1")+"sec";
		finishtimeText.text = "Time : " + time.ToString("N1")+"sec";
	}

}
