using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckSpearCollide : MonoBehaviour
{
    private Rigidbody rigid_body;

    void Start()
    {
        rigid_body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rigid_body.velocity = Vector3.zero;
        rigid_body.angularVelocity = Vector3.zero;
    }

    


}
