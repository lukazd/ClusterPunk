using UnityEngine;
using System.Collections;

public class MainCharacterControl : MonoBehaviour
{
    private CharacterController controller;
    private Vector2 movement;
    public int jumpSpeed = 1;

	// Use this for initialization
	void Start ()
    {
        controller = GetComponent<CharacterController>();
        movement = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ReadMovement();
        controller.Move(movement);
    }

    void ReadMovement()
    {
        bool hasJumped = Input.GetButtonDown("Jump");
        //Input.GetButton("left");
        //Input.GetButton("right");
        //transform.TransformDirection;

        if (hasJumped && controller.isGrounded)
        {
            movement = new Vector2(0, jumpSpeed) * Time.deltaTime;
        }
        else if (hasJumped)
        {
            movement = new Vector2(0, -jumpSpeed) * Time.deltaTime;
        }
    }
}
