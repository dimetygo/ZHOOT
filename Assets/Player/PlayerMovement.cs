using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public CharacterController characterController;
    public float gravity = -9.81f;
    Vector3 velocity;
    public float jumpHeigth = 3;
    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;

    bool isGrounded; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);
        if(isGrounded && velocity .y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHeigth * -2 * gravity);
        }
        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

       /* if(Input.GetKey(KeyCode.M))
        {
            velocity.x = speed * 2;
            velocity.y = speed * 2;
            velocity.z = speed * 2;
        }*/
        
       

    }
}
