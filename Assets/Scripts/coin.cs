﻿using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		gameObject.SetActive (false);
		PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score") + 100);

	}
}
