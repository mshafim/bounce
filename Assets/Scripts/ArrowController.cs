using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    private Rigidbody2D rb; 
    private Quaternion newRotation;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start () 
    {
        offset = transform.position - player.transform.position;
        rb = player.GetComponent<Rigidbody2D>();

    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
        Debug.Log(rb.velocity.magnitude);
        Debug.Log("magnitude");
        Debug.Log(360 * Mathf.Atan2(rb.velocity.y, rb.velocity.x) / 6.28);
        newRotation = Quaternion.Euler(0.0, 0.0, 360 * Mathf.Atan2(rb.velocity.y, rb.velocity.x) / 6.28);
        transform.rotation = rotation;
    }
}