using UnityEngine;
using System.Collections;

public class lookAtPlayer : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.LookAt (player.transform);
	}
}
