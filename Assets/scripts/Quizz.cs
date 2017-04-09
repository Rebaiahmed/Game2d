using UnityEngine;
using System.Collections;

public class Quizz : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {    
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100)) {
				// whatever tag you are looking for on your game object
				Debug.Log("tag is"+hit.collider.tag);
				if(hit.collider.tag == "Trigger") {                         
					Debug.Log("---> Hit: ");                        
				}
			}    
		}
	
	}
}
