using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    public float moveSpeed = 5f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;


    public CharacterController controller;

    public Animator anim;

    public Vector3 moveDirection = Vector3.zero;
    private float horizontalInput;                
    private float verticalInput;                
    
    void Start()
    {
        if (controller == null)
            controller = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void ApplyGravity(){
        if(controller.isGrounded){
            moveDirection.y = -0.5f;
            if (Input.GetButtonDown("Jump")){
                moveDirection.y = jumpSpeed;
            }

        }
        else{
            moveDirection.y -= gravity * Time.deltaTime;
        }
    }


}



