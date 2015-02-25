using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public Camera worldCamera;
	public float trackRate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xPos = worldCamera.transform.position.x;
		Vector3 pos = transform.position;
		pos.x = xPos;
		transform.position = pos;

		Vector2 vec = new Vector2 (xPos*trackRate, 0);
		renderer.sharedMaterial.SetTextureOffset("_MainTex", vec);
	}
}
