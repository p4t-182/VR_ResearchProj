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



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Left_Hand")
        {
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
        if (isThrusting && leftHandGrab == true)
        {
            Vector3 forwardDirection = rightController.transform.forward;

            Vector3 newPosition = playerOrigin.transform.position + forwardDirection * moveSpeed * Time.deltaTime;

            playerOrigin.transform.position = newPosition;
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
