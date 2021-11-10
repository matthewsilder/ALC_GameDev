using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; // How fast the player moves

    public float lookSensitivity; // How fast the mouse moves

    public float maxLookX; // Lowest down you can look

    public float minLookX; // Highest up you can look

    private Camera cam;
    private Rigidbody rb;

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 dir = transform.right * x + transform.forward * z;
        rb.velocity = dir;
    }

    void CamLook()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
