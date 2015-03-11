using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class damageControll : MonoBehaviour {

	public float health = 100f;
	public Text healthbar;
	Transform position;

	public Vector3 ObjectSpawnPosition;
	public Vector3 ObjectSpawnRotation;
	public GameObject player;
	GameObject player_instance;

	// Use this for initialization
	void Start () {
		position = GetComponent<Transform>();

		ObjectSpawnPosition.x = -45.06f;
		ObjectSpawnPosition.y = 0.0f;
		ObjectSpawnPosition.z = -105.55f;

		ObjectSpawnRotation.x = 0f;
		ObjectSpawnRotation.y = 0f;
		ObjectSpawnRotation.z = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		int healthvalue = (int)health;
		healthbar.text = "Health: " + healthvalue.ToString();

		if (health <= 0f){

			player.transform.position = new Vector3(ObjectSpawnPosition.x,ObjectSpawnPosition.y,ObjectSpawnPosition.z);
			player.transform.rotation = Quaternion.Euler(ObjectSpawnRotation.x, ObjectSpawnRotation.y ,ObjectSpawnRotation.z);
			player.rigidbody.velocity = Vector3.zero;
			player.rigidbody.angularVelocity = Vector3.zero;

			health = 100;
		
		}

		if (position.position.y < -13.0f){

			player.transform.position = new Vector3(ObjectSpawnPosition.x,ObjectSpawnPosition.y,ObjectSpawnPosition.z);
			player.transform.rotation = Quaternion.Euler(ObjectSpawnRotation.x, ObjectSpawnRotation.y ,ObjectSpawnRotation.z);
			player.rigidbody.velocity = Vector3.zero;
			player.rigidbody.angularVelocity = Vector3.zero;

			health = 100;
		}
		
	}
}
