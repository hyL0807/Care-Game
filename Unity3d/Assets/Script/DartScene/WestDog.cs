using UnityEngine;
using System.Collections;

public class WestDog : MonoBehaviour {

	public int t = 0;
	public int b = 3;
	public int tc = 0;

	public GameObject finishPopup;
	public GUIText targetcoin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		pos.y = gameObject.transform.position.y;
		gameObject.transform.position = pos;
	}

	void getTarget()
	{
		t += 1;
	}

	void wrongTarget()
	{
		t -= 1;
		b -= 1;
		if (b <= 0) finishGame ();
	}

	void finishGame()
	{
		tc = (int)(t);
		PlayerStatus.coin += tc;
		targetcoin.text = tc.ToString ();
		finishPopup.SetActive(true);
	}


}
