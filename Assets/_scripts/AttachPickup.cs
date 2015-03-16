using UnityEngine;
using System.Collections;

public class AttachPickup : MonoBehaviour {
	public GameObject collector;
	public Rigidbody playerObject;

	void FixedUpdate() {
		collector.transform.localPosition = playerObject.transform.localPosition;
		collector.transform.localRotation = playerObject.transform.localRotation;
	}

void OnTriggerEnter(Collider other) {
//		if (other.gameObject.tag == "PickUp") {
//			other.gameObject.transform.parent = collector.transform;
//			System.Console.WriteLine ("bonk");
//			}
	}
}
