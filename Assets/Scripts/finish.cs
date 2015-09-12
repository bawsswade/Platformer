using UnityEngine;
using System.Collections;

public class finish : MonoBehaviour {

	public GameObject g;

	void Start()
	{
		g.SetActive(false);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score") + 100);
		gameObject.SetActive (false);
		Time.timeScale = 0;
		g.SetActive (true);
	}
}
