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
    public Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
      if(Mode.mode3D)
      {
        MovePlayer();
        RotatePlayer();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
      }
    }

    private void RotatePlayer()
    {
      transform.Rotate((Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), 0, Space.World);
    }

    void MovePlayer()
    {
        {

            Vector3 cameraForward = cam.transform.forward;
            Vector3 cameraRight = cam.transform.right;
            cameraForward.y = 0;
            cameraRight.y = 0;
            cameraForward.Normalize();
            cameraRight.Normalize();


            float moveForward = Input.GetAxis("Vertical");
            float moveSideways = Input.GetAxis("Horizontal");


            Vector3 movement = (cameraForward * moveForward + cameraRight * moveSideways) * moveSpeed;


            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
        }
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
