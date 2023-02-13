using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float turnSmoothTime = 0.51f;
    public float turnSmoothVelocity;

    public Transform groundCheck;
    public float gravity = -9.81f;
    Vector3 velocity;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGround;

    public Transform cam;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertiacl = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertiacl);

        if (direction.magnitude > 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) *
                                            Mathf.Rad2Deg  + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                                                targetAngle, ref turnSmoothVelocity,
                                                turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(movDir.normalized * speed * Time.deltaTime);


            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

            anim.SetBool("Idle", false);
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Walking", false);
        }
    }
}