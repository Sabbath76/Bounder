using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject player;
	public float trackSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = Mathf.Lerp(pos.x, player.transform.position.x, trackSpeed*Time.deltaTime);
		transform.position = pos;
	}
}
