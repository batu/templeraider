using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	Collider triggerobject;
	public GameObject worm;
	public float worm_speed = 5.0f ;
	public Camera old_cam;
	public Camera new_cam;
	bool doomsday = false;
	// Use this for initialization

	void OnTriggerEnter (Collider triggerobject) {
		Debug.Log("collision detected");
		if(triggerobject.name == "Player Object"){
			Debug.Log("triggered");
			doomsday = true;
		}
	}
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0);
		}
		if ( doomsday == true){

			worm.rigidbody.AddForce(worm.transform.up * worm_speed);

			new_cam.enabled = true;
			old_cam.enabled = false;
 		}
	}
}
