using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour 
{

	private Animator animator;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("Direction", 5);
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		var vertical = Input.GetAxisRaw ("Vertical"); 
		var horizontal = Input.GetAxisRaw ("Horizontal");

		if (vertical > 0) {
			animator.SetInteger ("Direction", 2);
		} else if (vertical < 0) {
			animator.SetInteger ("Direction", 0);
		} else if (horizontal > 0) {
			animator.SetInteger ("Direction", 3);
		} else if (horizontal < 0) {
			animator.SetInteger ("Direction", 1);
		} else if (vertical == 0) {
			animator.SetInteger ("Direction", 5);
		} else if (horizontal == 0) {
			animator.SetInteger ("Direction", 5);
		}
		int val = animator.GetInteger ("Direction");
		Debug.Log (val);
	}
}
	
