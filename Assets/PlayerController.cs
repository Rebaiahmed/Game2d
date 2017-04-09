using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float maxSpeed ;
	Rigidbody2D myrb2d ;
	Animator myAnim ;
	bool facingRight ;
	private int sign;
	private float speed = 2.5f;

	// Use this for initialization
	void Start () {
	
		myrb2d = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();
		facingRight = true;

	

	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetAxis("Horizontal") > 0.5f){

			sign = 1;

		}else if (Input.GetAxis("Horizontal") < -0.5f){

			sign = -1;

		}else
			sign = 0;

		transform.Translate (speed * sign, 0, 0);

	}





	//*****************************//
	void flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


	//******************************************************//

	private void moveForward(float speed) {
		transform.localPosition += transform.forward * speed * Time.deltaTime;
	}

	private void moveBack(float speed) {
		transform.localPosition -= transform.forward * speed * Time.deltaTime;
	}

	private void moveRight(float speed) {
		transform.localPosition += transform.right * speed * Time.deltaTime;
	}

	private void moveLeft(float speed) {
		transform.localPosition -= transform.right * speed * Time.deltaTime;
	}



}
