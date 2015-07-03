using UnityEngine;
using System.Collections;

public class groundCheck : MonoBehaviour {

	public player_movement player;

	void Start()
	{
		player = gameObject.GetComponentInParent<player_movement> ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		player.isGrounded = true;
	}

	void OnTriggerExit2D(Collider2D col)
	{
		player.isGrounded = false;
	}
}
