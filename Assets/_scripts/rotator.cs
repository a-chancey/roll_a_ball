using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (transform.parent.tag != "PickupHolder") {
			transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);	
		}
	}
}
