using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public MovePlayer player ;
	public int scoreValue;
	/*public AudioClip crashWin;
	public AudioClip crassLost;*/







	private float lowPitchRange = .75F;
	private float highPitchRange = 1.5F;
	private bool isClicked ;
	private bool ClickedWin;
	public   bool isCorrect;
	public GameObject[] boxes;
	public GameObject[] popupes;


	private AudioSource source;
	public AudioClip lost ;
	public AudioClip correct ;
	public AudioClip GameSound;
	public AudioClip gameover;




	public GameObject gamovermenu;
	public GameObject nextObject ;
	public GameObject[] likes;
	private int index =0;
	private int indexquiz = 0;


	// Use this for initialization
	void Start () {
		isClicked = false;
		ClickedWin = false;
		this.isCorrect = false;
		this.index = 0;
		source = GetComponent<AudioSource>();
		this.source.Play ();
		GameObject gameControllerObject = GameObject.FindWithTag("Player");
		if (gameControllerObject != null)
		{
			player = gameControllerObject.GetComponent <MovePlayer>();
		}
		if (player == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}

		//********************//
	
		//audio.Play(44100);

		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();

		audio.clip = GameSound;
		//saudio.Stop();

		//**************initialize the sounds*************//

	

	}
	
	// Update is called once per frame
	void Update () {
	

		if (index > 2) {

			//ici afficher GameOver*********
			AudioSource audio = GetComponent<AudioSource>();
			audio.Stop ();
			this.gamovermenu.SetActive(true);
			this.player.StopAnimation();
			Debug.Log ("play aduio sound");
			source.pitch = Random.Range (lowPitchRange, highPitchRange);
			source.clip = gameover;
			//source.PlayOneShot (gameover, 1);
			source.Play ();
			this.boxes [indexquiz].SetActive (false);
			this.popupes [indexquiz].SetActive (false);
		
		}


		//***********vérifie pour passer la scéne2***************//

		Debug.Log ("index quizz" + this.indexquiz);

		/*if (indexquiz == 5) {
			//****display the panle of next level*****/
			//this.nextObject.SetActive(true);
		//}


	}


	//*************************************//
	void Awake () {

		//initialize the source Componennt
		//source = GetComponent<AudioSource>();
	}


	//*********************************************//

	public void OnclickTrue()
	{
		//Time.timeScale = 1;
		Debug.Log ("true choice");
		this.source.Stop ();
		if (isClicked == false) {
			ClickedWin = true;
			this.boxes [indexquiz].SetActive (false);
			this.popupes [indexquiz].SetActive (false);
			//*****incrementer indexquiz
			this.indexquiz++;
			source.pitch = Random.Range (lowPitchRange, highPitchRange);
			source.PlayOneShot (correct, 1);
			Debug.Log ("true choice");

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		
		}

		isClicked = false;

	}


	//*****************************************//
	public void OnClickWrong()
	{
		AudioSource audio = GetComponent<AudioSource>();
		if (ClickedWin == false) {
			isClicked = true;
			this.isCorrect = false;


			audio.Stop ();

			//**********pour déclencher le son***********
			source.pitch = Random.Range (lowPitchRange, highPitchRange);
			source.PlayOneShot (lost, 1);

			Debug.Log ("we are here");
			//**********************************************//
		
			//µ*******ici on va décrementer le nombre de lignes de vies*********************//

			Debug.Log ("the value of index is " + index);

			if (index > 2) {

				//ici afficher GameOver*********

				/*Debug.Log ("we are here");
				this.gamovermenu.SetActive(true);
				//***********arréter l'animation du player****************/
				/*Debug.Log("stoppp");*/
				//this.player.StopAnimation();
				source.pitch = Random.Range (lowPitchRange, highPitchRange);
				source.PlayOneShot (gameover, 1);
				this.boxes [indexquiz].SetActive (false);
				this.popupes [indexquiz].SetActive (false);
			} else {
				/*GameObject ChildGameObject1 = Healthheart.transform.GetChild (this.index).gameObject;
				Debug.Log (ChildGameObject1);
				ChildGameObject1.SetActive (false);*/
				this.likes[index].SetActive (false);
				index++;
			}
	
		

		}
	
		audio.Play();
		isClicked = false;
	}



	//****************************************//

	public bool CorrectValue()
	{
		return this.isCorrect;	
	}


	///******************************//
	/// 
	/// function to exit from the Game
	/// 
	public void ExitGame()
	{
		Debug.Log ("we will exit from the Game");
		this.gamovermenu.SetActive(false);
		Application.Quit();
	}

	//************************//
	public void RestartGame()
	{
		Debug.Log ("we will Restart the Game");
		this.gamovermenu.SetActive(false);
		Application.LoadLevel(Application.loadedLevel-1);
	}


	//******************************//

	public void nextlevel()
	{
		Debug.Log ("we will go to next level");
		Application.LoadLevel(Application.loadedLevel+1);
	}


}
