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
        Debug.Log(Mathf.Atan2((float)rb.velocity.y, (float)rb.velocity.x));

    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        transform.position = player.transform.position + offset;
        Debug.Log(rb.velocity.magnitude);
        Debug.Log("magnitude");
        newRotation = 360 * Mathf.Atan2((float)rb.velocity.y, (float)rb.velocity.x) / 6.28;
        Debug.Log(newRotation);
        newRotation = Quaternion.Euler(0.0, 0.0, newRotation);
        transform.rotation = newRotation;
    }
}