using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddles : MonoBehaviour {

	public float moveSpeed = 10f;

	public GameObject leftPaddle;
	public GameObject rightPaddle;


	void Update() {
		UpdateLeftPaddle();
		UpdateRightPaddle();

	}

	private void UpdateLeftPaddle() {
		leftPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		if (Input.GetKey(KeyCode.W)) {
			leftPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, moveSpeed);
		} else if (Input.GetKey(KeyCode.S)) {
			leftPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -moveSpeed);
		}
	}

	private void UpdateRightPaddle() {
		rightPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		if (Input.GetKey(KeyCode.UpArrow)) {
			rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, moveSpeed);
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			rightPaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -moveSpeed);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {

	}

}
