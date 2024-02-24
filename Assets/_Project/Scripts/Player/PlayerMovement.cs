using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    [SerializeField] private float RotationSpeed;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        RotatePlayer();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    private void RotatePlayer()
    {
      transform.Rotate((Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), 0, Space.World);
    }

    void MovePlayer()
    {
        float moveForward = Input.GetAxis("Horizontal") * moveSpeed;
        float moveSideways = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 movement = new Vector3(moveSideways, 0.0f, moveForward);

        rb.velocity = new Vector3(movement.x, rb.velocity.y, -movement.z);
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
