using UnityEngine;
using System.Collections;


/*
 **** un script pour Gérer le Menu (les transitions entre les scénes , Audio Menu , les cliks sur les buttons *****) 

*/


public class MenuManager : MonoBehaviour {




	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	//*********************************//

	public void goHelp()
	{
		Debug.Log ("go next level level Help");
		Application.LoadLevel("Help");
	}

	//*********************************//

	public void goPlay()
	{
		Debug.Log ("go next level level play");
		Application.LoadLevel("level1");
	}

	//*********************************//

	public  void goAbout()
	{
		Debug.Log ("go next level level About");
		Application.LoadLevel("About");
	}

	//*********************************//

	public  void ExitGame()
	{
		Debug.Log ("we will exit from the Game");
		Application.Quit();
	}






}
