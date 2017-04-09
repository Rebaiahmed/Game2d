using UnityEngine;
using System.Collections;

public class HearthHeatlth : MonoBehaviour {
	public int nb_lives = 3;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//*******************************//
	void FixedUpdate () {
		Vector2 toTarget = player.transform.position - transform.position;
	
		float speed = 1.5f;

		transform.Translate(toTarget * speed * Time.deltaTime);
	}


	//*********************************************//
	public void pauseControl(){
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			//showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			//hidePaused();
		}
	}













}
