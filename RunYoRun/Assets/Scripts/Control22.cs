using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control22 : MonoBehaviour
{
    private CharacterController controller;
    public static bool gameOver;
    private Vector3 direction;
    public float forwardSpeed;
    public float maxSpeed;
    public Animator animator;

    private bool isSliding = false;
    private bool isJumping = false;

    private int desiredLane = 1;
    public float laneDistance = 4;
    public float jumpForce;
    public float Gravity = -20;
    // Start is called before the first frame update
    static public bool canMove = false;
    public AudioSource swipeSFX;
    public AudioSource jumpSFX;
    public AudioSource rollSFX;
    public GameObject levelController;
    public bool ishit = false;
   


    public Animator hitanimation;
    public AudioSource crushSFX;
   


    void Start()
    {
        controller = GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
            
            if (forwardSpeed < maxSpeed)
        
            forwardSpeed += 0.15f * Time.deltaTime;
        
        




        direction.z = forwardSpeed;

        if (ishit == false) { 
        if (controller.isGrounded )
        {
           
            if (SwipeCont.swipeUp || Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
               jumpSFX.Play();
                Jump();
                StartCoroutine(Jumping());
               
            }
        }
        else { 
                direction.y += Gravity * Time.deltaTime;
            }

        if (SwipeCont.swipeDown || Input.GetKeyDown(KeyCode.S) &&  !isSliding)
        {
            rollSFX.Play();
            StartCoroutine(Slide());

        }

        if (SwipeCont.swipeRight || Input.GetKeyDown(KeyCode.D))
        {
            swipeSFX.Play();
            desiredLane++;
            if (desiredLane == 3)
            {
                desiredLane = 2;
            }

        }
        if (SwipeCont.swipeLeft || Input.GetKeyDown(KeyCode.A))
        {
            swipeSFX.Play();
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }

        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
       
        if (transform.position != targetPosition)
        {
          
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 15 * Time.deltaTime;
          
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);

            
        }
        controller.Move(direction * Time.deltaTime);
        }
    }

    

    private void Jump()
    {
        direction.y = jumpForce;
    }
    
    private IEnumerator Slide()
    {
        isSliding = true;
        animator.SetBool("isSliding", true);
        controller.center = new Vector3(0, -0.2f, 0);
        controller.height = 0;
        yield return new WaitForSeconds(1f);
        controller.center = new Vector3(0, 0, 0);
        controller.height = 1f;
        animator.SetBool("isSliding", false);
        isSliding = false;

    }
    private IEnumerator Jumping()
    {
        isJumping = true;
        animator.SetBool("isJumping", true);
        yield return new WaitForSeconds(0.9f);
        animator.SetBool("isJumping", false);
        isJumping = false;


    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {
            levelController.GetComponent<LevelDistance>().enabled = false;

            levelController.GetComponent<GameOver>().enabled = true;
            ishit = true;
            crushSFX.Play();
            animator.SetBool("isHitting", true);


        }

       
    }

    

}
