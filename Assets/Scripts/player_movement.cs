using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	// params for animations
	public float speed = 10f;
	public float jumpStr;
	public bool isGrounded = false;
	public float maxVel = 2;

	// moving the rigid body
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
		jumpStr = 200f;
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("Speed", Mathf.Abs (Input.GetAxis ("Horizontal")));
		anim.SetBool ("isGrounded", isGrounded);

		
		if (Input.GetAxis("Horizontal") < -.01) {
			transform.localScale = new Vector3(-0.25f,.25f,1);
		}
		if (Input.GetAxis("Horizontal") > .01)
		{
			transform.localScale = new Vector3(0.25f,.25f,1);
		}
	}

	// Called once every frame of rigid body
	void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce (Vector2.right * speed * h);

		if (rb2d.velocity.x > maxVel) {
			rb2d.velocity = new Vector2(maxVel, rb2d.velocity.y);
		}
		if (rb2d.velocity.x < -maxVel) {
			rb2d.velocity = new Vector2(-maxVel, rb2d.velocity.y);
		}


		if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) {
			//rb2d.velocity = new Vector2(rb2d.velocity.x,  jumpStr);
			rb2d.AddForce(Vector2.up * jumpStr);
		}
	}

}
