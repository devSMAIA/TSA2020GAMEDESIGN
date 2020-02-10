using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowJavelin : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 throwVector;
    private Vector3 javelinPosition;
    private Vector3 javelinRotation;
    private Vector3 rotateJavelin;
    private bool throwable = true;

    [SerializeField] private float throwStrength = 0;
    [SerializeField] private Camera camera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotateJavelin = new Vector3(90f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        javelinPosition = new Vector3(camera.transform.localPosition.x + 0.66f, camera.transform.localPosition.y - 0.2f, camera.transform.localPosition.z + 1.09f);
        javelinRotation = camera.transform.rotation.eulerAngles;

        throwVector = camera.transform.forward;

        if (throwable)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.useGravity = true;
                transform.parent = null;

                for (int i = 0; i < throwStrength * 100; i++)
                {
                    rb.isKinematic = false;
                    rb.AddForce(throwVector);
                }

                StartCoroutine(ReturnJavelin());

                
            }
        }
    }

    IEnumerator ReturnJavelin()
    {
        throwable = false;

        yield return new WaitForSeconds(2);

        transform.localEulerAngles = javelinRotation;
        transform.Rotate(rotateJavelin, Space.Self);

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        throwable = true;
        rb.useGravity = false;
        transform.position = javelinPosition;
        transform.parent = camera.transform;
        rb.isKinematic = true;
    }
}
