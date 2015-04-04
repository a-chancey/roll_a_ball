using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class PlayerController : MonoBehaviour {
	public Rigidbody playerRigidBody;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;
	public Vector3 ballSize;
	private Vector3 upSize;
	public GameObject collector;
	public List<GameObject> pickupArray = new List<GameObject>();

	void Start() {
		count = 0;
		ballSize = playerRigidBody.transform.localScale;
		SetCountText ();
	}

	void FixedUpdate()
	{
		if (pickupArray.Count >= 30) {
			GameObject removeMe = new GameObject();
			removeMe = pickupArray[0];
			pickupArray.RemoveAt(0);
			Destroy(removeMe);
		}
	}

	void Update() {
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp" ||other.gameObject.tag == "SmallPickup") {
			other.gameObject.GetComponent<Collider>().isTrigger = false;
			other.gameObject.GetComponent<Collider>().enabled = false;
			pickupArray.Add(other.gameObject);

			SetGrowthSize(other.transform.localScale);
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

	void SetGrowthSize(Vector3 other) {
		upSize.x = (other.x / ballSize.x) / 8;
		upSize.y = (other.y / ballSize.y) / 8;
		upSize.z = (other.z / ballSize.z) / 8;
	}
}