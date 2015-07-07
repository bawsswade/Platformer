using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject menu;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			menu.SetActive(!menu.activeSelf);
			if(Time.timeScale == 0)
				Time.timeScale = 1;
			else 
				Time.timeScale = 0;
		}
	}
}
