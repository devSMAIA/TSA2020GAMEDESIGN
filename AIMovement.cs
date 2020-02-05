using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private float MovementSpeed = 4f;
    [SerializeField] private float MaxDist = 10f;
    [SerializeField] private float MinDist = 5f;


    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MovementSpeed * Time.deltaTime;
        }

        if(Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            // Input Firing Script here
        }
    }
}
