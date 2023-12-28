using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator animator;


    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("punch");
        }


        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
            

            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isRunning", true);
            }
            
        }
        else
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);

        }
        
        



        
    }
}
