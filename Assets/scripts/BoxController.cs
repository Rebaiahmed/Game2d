using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {


	public Animation animation;
	//private Animator yourAnimator;

	// Use this for initialization
	void Start () {
	
		animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		//animation.Play ("");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Animator anim = GetComponent<Animator>();
			if (null != anim)
			{
				Debug.Log("Playing anim");
				anim.Play("anim");
			}
		}


	}


//*****************************************************//


//******************************************************//





	/*void OnCollisionEnter2D(Collision2D coll) {

		print("Detected collision between " + gameObject.name + " and " +coll.collider.name);
		print("There are " + coll.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + coll.relativeVelocity);


		Debug.Log ("we are here");
		if (coll.gameObject.tag == "box1") {
			coll.gameObject.SendMessage("ApplyDamage", 10);
			Debug.Log ("we will play animation");
		}
			
		//this.animation.Play ("enigme_animation");

	}*/

}
