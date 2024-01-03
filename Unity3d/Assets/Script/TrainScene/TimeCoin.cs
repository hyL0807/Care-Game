using UnityEngine;
using System.Collections;

public class TimeCoin : MonoBehaviour {

	public GUIText timeCoin;

	GameObject train;

	// Use this for initialization
	void Start () {
		train = GameObject.Find("Train");
	}
	
	// Update is called once per frame
	void Update () {
		timeCoin.text = train.GetComponent<Train> ().timecoin.ToString();
	}
}
