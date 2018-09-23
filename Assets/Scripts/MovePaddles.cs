using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddles : MonoBehaviour {

	public float moveSpeed = 0.015f;


	void Update() {
		float move = Input.GetAxis("Vertical") * moveSpeed;
		transform.Translate(move * Vector2.up);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("Yup, you did you a collision.");
		if (collision.gameObject.CompareTag("Wall")) {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}
	}

}
