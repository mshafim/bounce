using UnityEngine;
using System.Collections;

public class AccelArrowController : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector2 newAccel;
    private Quaternion newRotation;
    private double atan;
    private float degrees;
    private Vector3 scale;

    // Use this for initialization
    void Start () 
    {
        newRotation = new Quaternion();
        scale = new Vector3 (0, 0, 0);
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        // changes position to ball's position
        transform.position = player.transform.position;
        newAccel = player.GetComponent<AccelFinder>().acceleration;
        // changes scale to the magnitude of ball's acceleration, relatively
        scale = new Vector3 (newAccel.magnitude / 15, 1 + (newAccel.magnitude /15), 1);
        transform.localScale = scale;
        // changes rotation to direction of ball's acceleration
        atan = 360 * Mathf.Atan2(newAccel.y, newAccel.x) / 6.28;
        degrees = (float)atan;
        newRotation = Quaternion.Euler(0, 0, degrees);
        transform.rotation = newRotation;
    }
}