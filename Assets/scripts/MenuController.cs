using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class MenuController : MonoBehaviour {

	public AudioClip first;
	public AudioClip second ;



	// Use this for initialization
	void Start () {
		//squietMenu = quietMenu.GetComponent<Canvas> ();
		AudioSource audio = GetComponent<AudioSource>();
	
		audio.PlayOneShot(first, 0.7F);
		/*audio.Play();
		audio.Play(44100);*/

		/*sounds = GetComponents<AudioSource>();
		noise1 = sounds[0];
		noise2 = sounds[1];

		Debug.Log ("sound" + noise1);
		Debug.Log ("sound" + noise2);*/
	}
	

	public void StartPlaying()
	{
		Debug.Log ("Play");
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot(second, 0.7F);
	
		Application.LoadLevel(1);
	}


	//***********************************//

	public void StartAbout()
	{
		Debug.Log ("about");
		Application.LoadLevel(4);
	}



//*********************************************//

	public void StartHelp()
	{
		Debug.Log ("help");
		Application.LoadLevel(5);
	}


}
