using UnityEngine;
using System.Collections;

public class damageControll : MonoBehaviour {

	public float health = 100f;
	Transform position;



	// Use this for initialization
	void Start () {
		position = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0f){
			Destroy (gameObject);
		}

		if (position.position.y < 0.5f){
			Destroy (gameObject);
		}
		
	}
}
