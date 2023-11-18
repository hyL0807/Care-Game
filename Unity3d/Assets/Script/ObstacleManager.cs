using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {

	public GameObject fence;

	public float spawnTimer = 2.0f;

	float[] yList = new float[3];
	int idx = 0;
	float xPos = 8f;
	float yPos = 0f;

	// Use this for initialization
	void Start()
	{
		yList[0] = 0.64f;
		yList[1] = -1.65f;
		yList[2] = -3.9f;

	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer -= Time.deltaTime;
		if(spawnTimer <= 0.0f)
        {
			idx = Random.Range(0, 3);
			yPos = yList[idx];
			Instantiate(fence, new Vector2(xPos, yPos), Quaternion.identity);
			spawnTimer = 2.0f;
		}

	}
}
