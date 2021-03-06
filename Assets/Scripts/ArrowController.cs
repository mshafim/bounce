﻿using UnityEngine;
using System.Collections;
using TMPro;

public class ArrowController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    public Vector2 velocity;
    private Rigidbody2D rb;
    private Quaternion newRotation;
    private double atan;
    private float degrees;
    private Vector3 scale;

    private GameObject obj;
    private TextMeshProUGUI display;
    private Transform t;

    // Use this for initialization
    void Start () 
    {
        rb = player.GetComponent<Rigidbody2D>();
        newRotation = new Quaternion();
        scale = new Vector3 (0, 0, 0);
        velocity = new Vector2 (0, 0);

        obj = GameObject.FindWithTag("Velocity");
        display = obj.GetComponent<TextMeshProUGUI>();
        display.text = "Velocity Vector: (0, 0)";
        t = GetComponent<Transform>();
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
    	velocity = new Vector2 (rb.velocity.x, rb.velocity.y);
        // changes position to ball's position
        transform.position = player.transform.position;
        // changes scale to the magnitude of ball's velocity, relatively
        scale = new Vector3 (rb.velocity.magnitude / 10, 1 + (rb.velocity.magnitude / 20), 1);
        transform.localScale = scale;
        // changes rotation to direction of ball's velocity
        atan = 360 * Mathf.Atan2(rb.velocity.y, rb.velocity.x) / 6.28;
        degrees = (float)atan;
        newRotation = Quaternion.Euler(0, 0, degrees);
        transform.rotation = newRotation;
        if (t.position[0] > -1.7)
        {
            display.text = "Velocity Vector: (" + rb.velocity.x + ", " + rb.velocity.y + ")";
        }
    }
}