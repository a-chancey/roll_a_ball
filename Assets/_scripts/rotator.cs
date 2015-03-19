using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {
	public GameObject playerObject;
	public GameObject pickup;
	void Start() {
		playerObject = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (transform.parent.tag != "PickupHolder") {
			transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		}
		if ((((playerObject.transform.localScale.x / 2f) * (playerObject.transform.localScale.x / 2f) * (playerObject.transform.localScale.x / 2f)) * 3.14f * (4 / 3))/4 > (pickup.transform.localScale.x * pickup.transform.localScale.y * pickup.transform.localScale.z)) {
			pickup.gameObject.GetComponent<Collider> ().isTrigger = true;

		}
	}
}
