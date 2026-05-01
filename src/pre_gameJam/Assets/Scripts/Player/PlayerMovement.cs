using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerBody;

    [SerializeField] float _speed = 10f;
    [SerializeField] float _sprintSpeed = 20f;
    [SerializeField] float _gravityMultiplier = 2f;

    public Transform orientation;

    //private bool isSprinting = false;
    
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }


    void Walking()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Unity New Input System supports Key mapping... So later settings menu will be much easier to make
        // Sry for spaghetti it is dumb Unity moment - FK
        if (Keyboard.current != null){
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) horizontal += 1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) horizontal -= 1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) vertical += 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) vertical -= 1f;
        }


        Vector3 movement = (orientation.right * horizontal + orientation.forward * vertical).normalized;
        float currentSpeed = Sprint() ? _sprintSpeed : _speed;

        Vector3 newVelocity = movement * currentSpeed;
        newVelocity.y = playerBody.linearVelocity.y;
        
        playerBody.linearVelocity = newVelocity;
    }

    bool Sprint()
    {
        if(Keyboard.current != null && Keyboard.current.shiftKey.isPressed) return true;
        return false; 
    }

    void FixedUpdate()
    {
        Walking();

        /*
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = ((transform.right * horizontal) + (transform.forward * vertical)) * _speed;

        movement.y = playerBody.linearVelocity.y; 
        playerBody.linearVelocity = movement;
        
        */


        // gravitation force down - FK
        playerBody.AddForce(Physics.gravity * _gravityMultiplier, ForceMode.Acceleration);
    }
}