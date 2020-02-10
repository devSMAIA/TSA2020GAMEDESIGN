using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerCode : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private float movementSpeed;
    private float x;
    private float z;
    private Vector3 movement;

    // Update is called once per frame
    void Update()
    {
       
    }
}
