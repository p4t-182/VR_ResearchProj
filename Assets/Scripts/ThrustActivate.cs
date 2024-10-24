using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ThrusterActivate : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;

    private bool leftHandGrab;

    public InputActionReference trigger;
    public GameObject rightController;
    public float moveSpeed = 1.0f;
    private bool isThrusting = false;

    private Vector3 currentVelocity = Vector3.zero;
    public float dragCoefficient = 0.8f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Left_Hand")
        {
            Debug.Log("Left hand touching thruster");
            leftHandGrab = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Left_Hand")
        {
            leftHandGrab = false;
        }
    }

    void Start()
    {
        trigger.action.performed += StartThrust;
        trigger.action.canceled += StopThrust;
    }

    void Update()
    {
        if (isThrusting && leftHandGrab)
        {
            Vector3 forwardDirection = rightController.transform.forward;
            currentVelocity += forwardDirection * moveSpeed * Time.deltaTime; 
        }

        if (!isThrusting)
        {
            currentVelocity -= currentVelocity * dragCoefficient * Time.deltaTime; 
        }

        playerOrigin.transform.position += currentVelocity * Time.deltaTime;

        if (currentVelocity.magnitude < 0.01f) 
        {
            currentVelocity = Vector3.zero;
        }
    }

    void StartThrust(InputAction.CallbackContext context)
    {
        isThrusting = true;
    }

    void StopThrust(InputAction.CallbackContext context)
    {
        isThrusting = false;
    }
}
