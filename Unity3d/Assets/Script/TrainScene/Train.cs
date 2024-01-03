using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

	float lPosX = 0f;
	float rPosX = 0f;
	float xScreenHalfSize;
	float yScreenHalfSize;

	GameObject t;

	public int hp = 3;
	public int c = 0;
	public int timecoin = 0;

	public GameObject finishPopup;

	public GUIText coinnum1;
	public GUIText coinnum2;

	// Use this for initialization
	void Start () {

		//player position setting
		transform.position = new Vector2(-7.7f,-1.3f);

		//camera height, width
		yScreenHalfSize = Camera.main.orthographicSize;
		xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;

		lPosX = -xScreenHalfSize;
		rPosX = xScreenHalfSize;

		t = GameObject.Find("Timer");
		
	}

	void getDamage()
	{
		hp -= 1;
		if (hp <= 0) finishGame();
	}

	void getCoin()
    {
		c += 1;
		coinnum1.text = c.ToString ();
		coinnum2.text = c.ToString ();
    }

	void finishGame()
	{
		timecoin = (int)(t.GetComponent<TimeManager> ().time * 0.5);
		PlayerStatus.coin += c;
		PlayerStatus.coin += timecoin;
		finishPopup.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey("d"))
        {
			if(transform.position.x < rPosX)
            {
				transform.Translate(new Vector2(0.5f, 0));
            }
		}
        if (Input.GetKey("a"))
        {
			if (transform.position.x > lPosX)
			{
				transform.Translate(new Vector2(-0.5f, 0));
			}
		}
        if (Input.GetKey("w"))
        {
			if(transform.position.y < 0.7)
            {
				transform.Translate(new Vector2(0, 1.0f));
            }
        }
		if (Input.GetKey("s"))
		{
			if (transform.position.y > -3.4)
			{
				transform.Translate(new Vector2(0, -1.0f));
			}
		}

	}

	
}
