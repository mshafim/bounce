using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBall : MonoBehaviour {
	private Rigidbody2D rb;
	public float up_boost;
	public float right_boost;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Game Floor Sprite Blue")
		{
			rb.AddForce(transform.up * up_boost);
			rb.AddForce(transform.right * right_boost);

		}
	}
}
