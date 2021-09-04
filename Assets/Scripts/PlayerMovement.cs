using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float speed = 10f;

    public float horizontalMove = -1f;
    public bool isJumping = false;

    private void Update()
    {
        // horizontalMove = Input.GetAxis("Horizontal");
        // if (Input.GetKey(KeyCode.Space))
        // {
        //     isJumping = true;
        // }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * speed * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;
    }
}