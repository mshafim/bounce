using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour {
	private Transform t;
	private float count;
	private float y;
	private Rigidbody2D rb;
	public GameObject restart_button;
	public GameObject quit_button;
	public GameObject height;
	// public GameObject boost;


	// Use this for initialization
	void Start () {
		restart_button.SetActive(false);
		quit_button.SetActive(false);

		height.SetActive(true);
		// boost.SetActive(true);

		t = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
		y = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
        {
			height.SetActive(false);
			// boost.SetActive(false);
		}

		if (Input.GetKeyDown("q"))
		{
			rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
			restart_button.SetActive(true);
			quit_button.SetActive(true);
		}

		y = t.position[1];
	}
}
