﻿using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {

	public GameObject player;
	public float smoothOffset = .05f;

	private Vector2 vel;
	public Vector3 minCamPos;
	public Vector3 maxCamPos;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float xPos = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref vel.x, smoothOffset);
		float yPos = Mathf.SmoothDamp (transform.position.y, player.transform.position	.y, ref vel.y, smoothOffset);

		transform.position = new Vector3 (xPos, yPos, transform.position.z);

		if(transform.position.x < minCamPos.x)
		{
			transform.position = new Vector3(minCamPos.x, transform.position.y, transform.position.z);
		}
		if(transform.position.x > maxCamPos.x)
		{
			transform.position = new Vector3(maxCamPos.x, transform.position.y, transform.position.z);
		}
		if(transform.position.y < minCamPos.y)
		{
			transform.position = new Vector3(transform.position.x, minCamPos.y, transform.position.z);
		}
	}

	public void SetMinPos()
	{
		minCamPos = transform.position;
	}

	public void SetMaxPos()
	{
		maxCamPos = transform.position;
	}
}
