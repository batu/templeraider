using UnityEngine;
using System.Collections;

public class trapDamage : MonoBehaviour {


	Collider thingCurrentlyInside;
	public float dps = 35f;
	
	// Update is called once per frame
	void Update () {
		if (thingCurrentlyInside != null){
			if (thingCurrentlyInside.name == "Player Object"){
				thingCurrentlyInside.GetComponent<damageControll>().health -= Time.deltaTime * dps;
			}
		}
	}


	// Unity automatically calls this function when an object with 
	// a rigidbody enters this objects trigger collider, AND it will tell you WHAT entered it.

	void OnTriggerEnter (Collider activator) {
		thingCurrentlyInside = activator; // catch it in a variable.
	}

	void OnTriggerExit ( Collider exiter){
		thingCurrentlyInside = null;
	} 

}
