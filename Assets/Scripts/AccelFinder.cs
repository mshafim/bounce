using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelFinder : MonoBehaviour {
	public GameObject player;
	private Rigidbody2D rb;
	public Vector2 acceleration;
	private Vector2 lastVelocity;

	// Use this for initialization
	void Start () {
		rb = player.GetComponent<Rigidbody2D>();
		lastVelocity = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		acceleration = (rb.velocity - lastVelocity) / Time.fixedDeltaTime;
		lastVelocity = rb.velocity;
	}
}
