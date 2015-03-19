using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public Rigidbody playerRigidBody;
	public float speed;
	public GameObject mainCamera;
	public GameObject playerContainer;
		void FixedUpdate()
		{
		if(Input.GetKey ("w")) {
			playerRigidBody.AddForce (mainCamera.transform.forward * 1.5f * speed * Time.deltaTime);
		}
		if (Input.GetKey ("s")) {
			playerRigidBody.AddForce(-mainCamera.transform.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey ("a")) {
			playerRigidBody.AddForce(-mainCamera.transform.right * speed * Time.deltaTime);
		}
		if (Input.GetKey ("d")) {
			playerRigidBody.AddForce(mainCamera.transform.right * speed * Time.deltaTime);
		}
		}
	}
