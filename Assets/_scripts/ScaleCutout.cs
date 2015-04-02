using UnityEngine;
using System.Collections;

public class ScaleCutout : MonoBehaviour {
	public GameObject player;
	public Camera mainCamera;
	public GameObject cutout;
	public float tubewidth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public Vector3 heading = new Vector3();
	public float distance = new float();
	public float multiplier = 1.5f;
	public float multiplier2 = 0.125f;
	void Awake() {
		//this.transform.position = 0.4f * (player.transform.position + mainCamera.transform.position);
	}


	void Update () {
		cutout.transform.localScale = new Vector3(tubewidth, 1.25f * distance, tubewidth);
		this.transform.localPosition = new Vector3(0, 0 , multiplier * -distance);
//		//distance = Vector3.Dot (heading, mainCamera.transform.forward);
//		cutout.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f); 
	}
	void FixedUpdate() {
		distance = player.transform.position.y - mainCamera.transform.position.y;
		tubewidth = player.transform.localScale.y * multiplier2;
	}
}
