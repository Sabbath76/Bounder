using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float maxTurnSpeed;
	public float turnInterpSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float leftVal = 0;
		float rightVal = 0;
		float leftTot = 0;
		float rightTot = 0;
		if (Input.touchCount > 0) {
			for (int i=0; i<Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.position.x < 40)
				{
					leftVal = touch.position.y / Screen.height;
					leftTot += 1;
				}
				else if (touch.position.x > Screen.width-40)
				{
					rightVal = touch.position.y / Screen.height;
					rightTot += 1;
				}
			}
		}
		else if (Input.GetButton ("Fire1")) {
			if (Input.mousePosition.x < 30)
			{
				leftVal = Input.mousePosition.y / Screen.height;
				leftTot += 1;
			}
			else if (Input.mousePosition.x > Screen.width - 30)
			{
				rightVal = Input.mousePosition.y / Screen.height;
				rightTot += 1;
			}

		}

		if (leftTot > 0) {
			leftVal /= leftTot;
		}
		if (rightTot > 0) {
			rightVal /= rightTot;
		}

		float turnSpeed = maxTurnSpeed * (leftVal - rightVal);
		rigidbody2D.angularVelocity = Mathf.Lerp(rigidbody2D.angularVelocity, turnSpeed, turnInterpSpeed*Time.deltaTime);
	}
}
