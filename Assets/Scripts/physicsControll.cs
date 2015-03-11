using UnityEngine;
using System.Collections;

public class physicsControll : MonoBehaviour {


    Rigidbody rbody;
	Transform position;
	public float speed = 5f;
	public float jumpconstant = 100f;
	public float turnrate = 5f;
	public float y_position;
	public float max_jump = 0.2f;

	bool can_jump = true;

	// Use this for initialization
	void Start () {
	
		rbody = GetComponent<Rigidbody>();
		position = GetComponent<Transform>();
		y_position = position.position.y;
	}
	
	// FixedUpdate is called one a fixed interval / every physics frame
    // Use this when you are doing with physics
	void OnCollisionEnter(Collision collision) {
		can_jump = true;
	}

	void FixedUpdate () {
	

		// INPUT AXES; A virtual joystick that returns a float from -1 to 1;

        rbody.AddForce( transform.forward * speed * Input.GetAxis( "Vertical" )
		               , ForceMode.VelocityChange);
		//rbody.AddForce( transform.right * speed * Input.GetAxis( "Horizontal"));
		transform.Rotate( 0f, Input.GetAxis ("Horizontal")  * turnrate , 0f );



		if ( position.position.y > y_position + max_jump){
			can_jump = false;
		}
		if ( position.position.y < -0.4f){
			can_jump = false;
		}
		if (can_jump){
			rbody.AddForce( transform.up * jumpconstant * Input.GetAxis( "Jump"));
		}



	}
}
