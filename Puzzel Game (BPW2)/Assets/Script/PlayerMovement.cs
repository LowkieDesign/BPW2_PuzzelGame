using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    public float walkSpeed;
  

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * walkSpeed * Time.deltaTime;
        transform.Translate(movement, Space.Self);


        if (vertical != 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("is_running", true);
                animator.SetBool("is_walking", false);
            }
            else
            {
                animator.SetBool("is_running", false);
                animator.SetBool("is_walking", true);
            }
        }
        else
        {
            animator.SetBool("is_running", false);
            animator.SetBool("is_walking", false);
        }
    }


}