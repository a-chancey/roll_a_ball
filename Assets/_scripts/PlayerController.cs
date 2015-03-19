using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {
	public Rigidbody playerRigidBody;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;
	public Vector3 ballSize;
	private Vector3 upSize;
	public GameObject collector;
	void Start() {
		count = 0;
		ballSize = playerRigidBody.transform.localScale;
		SetCountText ();
	}

	void FixedUpdate()
	{
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.GetComponent<Collider>().isTrigger = false;
			other.gameObject.GetComponent<Collider>().enabled = false;
			SetUpSize(other.transform.localScale);
			other.gameObject.transform.parent = collector.transform;
			ballSize = ballSize + upSize;
			playerRigidBody.transform.localScale = ballSize;
			count++;
			SetCountText();
		}
	}

	void SetCountText() {
		countText.text = "Size: " + ballSize.x.ToString ();
	}

	void SetUpSize(Vector3 other) {
		upSize.x = (other.x / ballSize.x) / 2 ;
		upSize.y = (other.y / ballSize.y) / 2;
		upSize.z = (other.z / ballSize.z) / 2;
	}

}