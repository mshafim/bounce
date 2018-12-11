using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVector : MonoBehaviour {
	Vector2 object_vector;

	public Collider2D objectCollider;
	public Collider2D rampCollider;

	private List<bool> Truths = new List<bool>();

	// Use this for initialization
	void Start () {
		objectCollider = GameObject.FindGameObjectWithTag("Object Sprite").GetComponent<Collider2D>();
		rampCollider = GameObject.FindGameObjectWithTag("Ramp Sprite v2").GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (objectCollider.IsTouching(rampCollider))
			Truths.Add(true);

		Debug.Log(Truths.Count);
	}
}
