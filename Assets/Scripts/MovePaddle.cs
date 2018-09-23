using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

	public float moveSpeed = 1;

	// Update is called once per frame
	void Update() {
		float move = Input.GetAxis("Vertical") * moveSpeed;
		transform.Translate(move * Vector2.up);
	}
}
