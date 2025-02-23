using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = transform.rotation * new Vector3(HorizontalInput(), rb.velocity.y) * moveSpeed;
    }

    private float HorizontalInput()
    {
        return Input.GetAxis("Horizontal"); 
    }
}
