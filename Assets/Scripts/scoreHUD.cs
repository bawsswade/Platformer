using UnityEngine;
using System.Collections;

public class scoreHUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("score", 0);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.guiText.text = "SCORE: " + PlayerPrefs.GetInt ("score");
	}
}
