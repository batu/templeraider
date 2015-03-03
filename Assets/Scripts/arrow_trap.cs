using UnityEngine;
using System.Collections;

public class arrow_trap : MonoBehaviour {



	public Vector3 ObjectSpawnPosition;
	public GameObject trap;
	public GameObject arrow;
	public GameObject player;

	public float arrow_speed;

	GameObject arrow_instance;
	Collider thingCurrentlyInside;



	// Use this for initialization
	void Start () {
		ObjectSpawnPosition.x = trap.transform.position.x;
		ObjectSpawnPosition.y = trap.transform.position.y;
		ObjectSpawnPosition.z = trap.transform.position.z;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider activator) {
		arrow_instance = (GameObject)Instantiate(arrow, ObjectSpawnPosition, Quaternion.identity);
		arrow_instance.rigidbody.AddForce(transform.forward * arrow_speed);
	}


}
