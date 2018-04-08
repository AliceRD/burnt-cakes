using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public float speed = 3.0F;
	public float drag = 1;
			
	//public float rotationSpeed = 100.0F;
	void Update() {
		float translation = Input.GetAxisRaw("Vertical") * speed;
		float translation2 = Input.GetAxisRaw("Horizontal") * speed;
		translation *= Time.deltaTime; // translation = translation * Time.deltaTime;
		translation2 *= Time.deltaTime; // translation2 = translation2 * Time.deltaTime;

		transform.Translate(translation2, translation, 0);
		//transform.Rotate(0, rotation, 0);
	}
}
