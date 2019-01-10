using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour {
	private float count;
	private Rigidbody2D rb;

	public GameObject restart_button;
	public GameObject quit_button;
	public GameObject height;

	public Collider2D floor;
	private Collider2D ball;

	// Use this for initialization
	void Start () {
		restart_button.SetActive(false);
		quit_button.SetActive(false);

		height.SetActive(true);

		rb = GetComponent<Rigidbody2D>();
		ball = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
        {
			height.SetActive(false);
		}

		if (ball.IsTouching(floor))
     	{
  			count++;
  			if (count == 200)
  			{
  				rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
  				restart_button.SetActive(true);
				quit_button.SetActive(true);
  			}
     	}

     	if (!ball.IsTouching(floor))
     	{
     		count = 0;
     	}
	}
}
