using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonControl : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    public float speed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float walkSpeed = 5f;
    public float sprintSpeed = 15f;
    public float momentum;
    public float speedChangeRate = 2f;

    private float targetSpeed;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Vector3 velocity;
    bool isGrounded;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        // groundcheck
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        //basic movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

  

        //DOESN'T SEEM TO BE ACCELERATING OR DECCELERATING
        // NEED float momentumEnd = 0f; if momentum < walk speed

        // sprinting acceleration, decceleration, and momentum
        targetSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed;

        //if player isn't moving, set targetSpeed = 0.0f
       if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            targetSpeed = 0.0f;

        }
       
        momentum = new Vector3(controller.velocity.x, 0.0f, controller.velocity.z).magnitude;

        float speedOffset = 0.1f;

        if (momentum < targetSpeed - speedOffset ||
            momentum > targetSpeed + speedOffset)
        {
            speed = Mathf.Lerp( momentum, targetSpeed , speedChangeRate * Time.deltaTime);
           
           

            Debug.Log("acceleration working");
            
          
        }
        else
        {
            speed = targetSpeed;
            Debug.Log("acceleration stopped");

        }



        //jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        //gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

      
        //Smoothing out Rotations
        if (direction.magnitude >= 0.1f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) *  Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; 
            controller.Move(moveDir.normalized * speed * Time.deltaTime); //Time.deltaTime makes movement framerate independent
        }
    }
}
