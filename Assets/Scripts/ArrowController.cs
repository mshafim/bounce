using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    private Rigidbody2D rb;
    private Quaternion newRotation;
    private double atan;
    private float degrees;
    private Vector3 scale;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start () 
    {
        offset = transform.position - player.transform.position;
        rb = player.GetComponent<Rigidbody2D>();
        newRotation = new Quaternion();
        scale = new Vector3 (0, 0, 0);
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
        Debug.Log(rb.velocity.magnitude);
        Debug.Log("magnitude");
        scale = new Vector3 (rb.velocity.magnitude / 10, 1, 1);
        transform.localScale = scale;
        atan = 360 * Mathf.Atan2(rb.velocity.y, rb.velocity.x) / 6.28;
        degrees = (float)atan;
        newRotation = Quaternion.Euler(0, 0, degrees);
        transform.rotation = newRotation;
    }
}