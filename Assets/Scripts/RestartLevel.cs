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


	// Use this for initialization
	void Start () {
		restart_button.SetActive(false);
		quit_button.SetActive(false);

		t = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
		y = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (t.position[0] > -5.13 && y == t.position[1])
		{
			count++;
		}

		if (count == 200)
		{
			rb.constraints = RigidbodyConstraints2D.FreezePositionX;
			restart_button.SetActive(true);
			quit_button.SetActive(true);
		}

		y = t.position[1];
	}
}
