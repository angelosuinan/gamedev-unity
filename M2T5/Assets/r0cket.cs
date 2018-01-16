using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r0cket : MonoBehaviour
{
    public Vector3 com;
    Rigidbody rigidbody;
    // Use this for initialization
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("tesrt");
            rigidbody.AddRelativeForce(Vector3.up * 20);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 2);
         }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 2);
        }
        

    }
}