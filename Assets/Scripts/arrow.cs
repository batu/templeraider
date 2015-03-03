using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

	Collider triggerobject;
	public GameObject player_object;
	public float arrow_damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider triggerobject) {
		if(triggerobject.name == "Player Object")
		{
			triggerobject.GetComponent<damageControll>().health -= arrow_damage;
		}

	}

}
