using UnityEngine;
using System.Collections;

public class float_beam : MonoBehaviour {

	// Use this for initialization
	
	public float tractor_speed = 1f;

	public float x_value = 0.88f;
	public float y_value = 0.57f;
	public float z_value = 1.15f;

	public float y_rotate = 15.4f;

	public GameObject player_object;
	public GameObject tractor_halo;

	Vector3 ObjectSpawnPosition;
	GameObject tractor_halo_instance;
	
	// Update is called once per frame
	void Update () {
		ObjectSpawnPosition.x = player_object.transform.position.x + x_value;
		ObjectSpawnPosition.y = player_object.transform.position.y + y_value;
		ObjectSpawnPosition.z = player_object.transform.position.z + z_value;
		Destroy(gameObject, 1f);
		Spawner();
		}

	void Spawner(){
		Debug.Log("spawning");
		tractor_halo_instance = (GameObject)Instantiate(tractor_halo, ObjectSpawnPosition, Quaternion.identity);
		tractor_halo_instance.transform.rotation = Quaternion.Euler(0f, y_rotate ,0f);
		tractor_halo_instance.rigidbody.AddForce(-transform.up * tractor_speed);
	}

	void Spawn_Interval() {
		InvokeRepeating("Spawner", 2, 0.8F);
	}



}
