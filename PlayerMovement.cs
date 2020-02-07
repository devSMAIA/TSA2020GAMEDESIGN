using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 movement;
    public CharacterController controller;

    void Start()
    {
        
    }


    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), -.2f, Input.GetAxis("Vertical"));

        controller.Move(movement);
    }
}
