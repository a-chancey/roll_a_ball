using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public Rigidbody playerRigidBody;
	public float speed;
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		playerRigidBody.AddForce (movement * speed * Time.deltaTime);
		
		
	}
}
