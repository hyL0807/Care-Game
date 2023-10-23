using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	public float speed;
	public Transform[] backgrounds;

	float lPosX = 0f;
	float rPosX = 0f;
	float xScreenHalfSize;
	float yScreenHalfSize;

	// Use this for initialization
	void Start () {
		yScreenHalfSize = Camera.main.orthographicSize;
		xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;

		lPosX = -xScreenHalfSize;
		rPosX = xScreenHalfSize * 2;
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < backgrounds.Length; i++)
        {
			backgrounds[i].position += new Vector3(-speed, 0, 0) * Time.deltaTime;

			if(backgrounds[i].position.x < lPosX)
            {
				Vector3 nextPos = backgrounds[i].position;
				nextPos = new Vector3(nextPos.x + rPosX, nextPos.y, nextPos.z);
				backgrounds[i].position = nextPos;
            }
        }
	}
}
