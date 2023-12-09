using UnityEngine;
using System.Collections;

public class RuleText : MonoBehaviour {

	public GUIText rulesText;

	// Use this for initialization
	void Start () {
		rulesText.text = "장애물을 피하면서 기찻길을 따라가세요"+"\n"
			+"창을 닫는 순간 시작합니다"+"\n"+"코인 "+"\t"+"장애물 "+"\t";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
