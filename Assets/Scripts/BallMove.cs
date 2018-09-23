using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

	public float force = 100;

	// Use this for initialization
	void Start() {
		gameObject.GetComponent<Rigidbody2D>().AddForce((Vector2.left + Vector2.up) * force);
	}

	// Update is called once per frame
	void Update() {

	}
}
