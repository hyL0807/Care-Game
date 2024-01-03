using UnityEngine;
using System.Collections;

public class TargetManager : MonoBehaviour {

	public GameObject[] randomTargets;

	public float spawnTimer = 2.0f;
	private float resetTime = 1.0f;

	Vector2 RandomPos()
	{
		float range_x = Random.Range (-7.0f, 7.0f);
		float range_y = Random.Range(-0.5f, 2.5f);

		Vector2 randomPos = new Vector2 (range_x, range_y);

		return randomPos;
	}

	GameObject RandomObject()
	{
		int select = Random.Range (0, randomTargets.Length);
		GameObject selectedObject = randomTargets [select];

		return selectedObject;
	}

	// Use this for initialization
	void Start () {
		resetTime = spawnTimer;
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer -= Time.deltaTime;
		if(spawnTimer <= 0.0f)
		{
			Instantiate(RandomObject(), RandomPos(), Quaternion.identity);
			spawnTimer = resetTime;
		}
	}
}
