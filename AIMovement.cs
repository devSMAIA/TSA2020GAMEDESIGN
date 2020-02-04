using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float MovementSpeed = 4f;
    public float MaxDist = 10f;
    public float MinDist = 5f;
    public GameObject Player;

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
