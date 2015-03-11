using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

	Collider thingCurrentlyInside;

	public float y_rotation;

	
	// Update is called once per frame


	void OnTriggerEnter (Collider activator) {

		thingCurrentlyInside = activator;


		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnPosition.x = transform.position.x;
		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnPosition.y = transform.position.y;
		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnPosition.z = transform.position.z;

		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnRotation.x = transform.rotation.x;
		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnRotation.y = y_rotation;
		thingCurrentlyInside.GetComponent<damageControll>().ObjectSpawnRotation.z = transform.rotation.z;

		Debug.Log(transform.rotation.y);
		Debug.Log(transform.localRotation.y);
	
	}
}
