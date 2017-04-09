using UnityEngine;
using System.Collections;

public class goNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("we are here  "+ coll.gameObject.tag );
		Application.LoadLevel (Application.loadedLevel + 1);

	}







}
