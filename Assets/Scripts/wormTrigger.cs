using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wormTrigger : MonoBehaviour {

	public Text gameover;
	// Use this for initialization

	void OnTriggerEnter (Collider triggerobject) {
		if(triggerobject.name == "Player Object" || triggerobject.name == "Treasure"){
			Destroy(triggerobject);
			gameover.text = "Congratulations! \n You managed to get eaten.\n\n Your time is: " + Time.timeSinceLevelLoad.ToString() + "\n\n\n Press R to restart and beat your fastest time!";
		}
	}
}
