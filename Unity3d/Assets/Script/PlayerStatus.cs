using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

	public static int coin = 0;

	public GUIText coinNum;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		coinNum.text = coin.ToString ();
	}
}
