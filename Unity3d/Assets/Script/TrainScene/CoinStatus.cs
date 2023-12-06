using UnityEngine;
using System.Collections;

public class CoinStatus : MonoBehaviour {

	public GUIText coinText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		coinText.text = Train.coin.ToString();
	}
}
