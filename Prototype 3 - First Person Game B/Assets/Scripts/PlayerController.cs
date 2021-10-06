using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement
    public float moveSpeed; // How fast the player moves
    public float jumpForce;
    //Camera
    public float lookSensitivity; // Mouse movement sensitivity
    public float maxLookX; // Lowest down we can look
    public float minLookX; // Highest up we can look
    private float rotX;    // Current x rotation of the camera

    //Components
    private Camera cam;
    private Rigidbody rb;

    void Awake()
    {
        // Get the components
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(x, rb.velocity.y, z);
    }
}
