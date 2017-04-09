using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class MovePlayer : MonoBehaviour {




	//***********new********************//
	private int sign;

	Rigidbody2D rbody;
	public Animator anim;

	private int finId1 = -1; //id finger for cancel touch event
	private int finId2 = -1;
	private float speed = 1.5f;
	private bool canJump;
	public float jumpPower = 190;
	public GameObject[] quizzs1;
	public GameObject[] quizzs2;
	//public Text scoreText;
	private int score;
	public ButtonController btn ;
	private bool shouldMove;

	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		/*rb2d = GetComponent<Rigidbody2D> ();
		input1.SetActive (false);*/
		//input.text = "Enter your answer ...";
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		//Input.multiTouchEnabled = true;

		//*****set anim to false
		anim.enabled = false ;
		canJump = true;
		//***attribut pour donner pouvoir a marcher****
		shouldMove = true;
		UpdateScore ();
	
		Debug.Log ("btn is true" + btn.isCorrect);
	}

	//***************************************************************//


	void Update () {

		anim.enabled = true;
		if (Input.GetAxis("Horizontal") > 0.5f){

			sign = 1;

		}else if (Input.GetAxis("Horizontal") < -0.5f){

			sign = -1;

		}else
			sign = 0;
		//shouldMove = true;
		if (shouldMove) {
			transform.Translate (speed * sign, 0, 0);
		}
	

		//**********script to jump*******************//

		/*if (Input.GetButtonDown ("Jump")) {
			//.velocity = 5f * (Vector2.up);
			Debug.Log("we will jump");
			//rbody.velocity = 5f * (Vector2.up);
			transform.position = new Vector2(0,5f);
			canJump = false;
		}*/


		//****************wehn click to the right response************//
	


	

	}















void OnCollisionEnter2D(Collision2D coll) {




		Debug.Log ("tag is " + coll.gameObject.tag);
		anim.enabled = false;

		switch (coll.gameObject.tag)
		{

		//************************//
	

		case "obst1":
			//Time.timeScale = 0;
			Debug.Log ("cactus 1");
			quizzs1[0].SetActive (true);
			break;

		case "obst2":
			//Time.timeScale = 0;
			Debug.Log ("cactus 2");
			quizzs1[1].SetActive (true);
			break;

		case "obst3":
			//Time.timeScale = 0;
			Debug.Log ("cactus 2");
			quizzs1[2].SetActive (true);
			break;

		case "obst4":
			//Time.timeScale = 0;
			Debug.Log ("cactus 2");
			quizzs1[3].SetActive (true);
			break;


		case "obst5":
			//Time.timeScale = 0;
			Debug.Log ("cactus 2");
			quizzs1[4].SetActive (true);
			break;

		case "obst6":
			//Time.timeScale = 0;
			Debug.Log ("cactus 2");
			quizzs1[5].SetActive (true);
			break;
	

		case "box1":
			//Time.timeScale = 0;
			Debug.Log ("box1");
			quizzs2[0].SetActive (true);
			break;
		


		case "box2":
			Debug.Log (" box2");
			quizzs2[1].SetActive (true);
			break;

		case "box3":
			Debug.Log (" box3");
			quizzs2[2].SetActive (true);
			break;

		case "box4":
			Debug.Log (" box4");
			quizzs2[3].SetActive (true);
			break;

		case "box5":
			Debug.Log (" box5");
			quizzs2[4].SetActive (true);
			break;

		case "scene2":
			Debug.Log ("we will move to scene 2 :D");
			break;
		
		default:
			Debug.Log ("go to scene2");
			break;
		}

	
			
	

	//this.animation.Play ("enigme_animation");

}


	//***************function to update core****************//
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		Debug.Log ("score sera " + score);
		UpdateScore ();
	}

	void UpdateScore ()
	{
		//scoreText.text = "Score: " + score.ToString ();
	}

	//*********************//


	public void StopAnimation()
	{
		//********ici on va stopper l'animation*******************//
		Debug.Log("on va arréter l'animation ici ");
		this.anim.enabled = false ;
	}


}
