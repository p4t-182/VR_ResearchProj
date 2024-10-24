using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class DualThrusterActivate : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;

    public InputActionReference leftTrigger;
    public InputActionReference rightTrigger;
    public GameObject rightController;
    public GameObject leftController;
    private GameObject activeController;
    public float moveSpeed = 1.0f;
    private bool isThrusting = false;

    private Vector3 currentVelocity = Vector3.zero;
    public float dragCoefficient = 0.8f;

    void Start()
    {
        leftTrigger.action.performed += OnLeftTriggerPerformed;
        leftTrigger.action.canceled += OnLeftTriggerCanceled;
        rightTrigger.action.performed += OnRightTriggerPerformed;
        rightTrigger.action.canceled += OnRightTriggerCanceled;
    }

    void Update()
    {
        if (isThrusting && activeController != null)
        {
            Vector3 forwardDirection = activeController.transform.forward * -1;
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

    private void OnLeftTriggerPerformed(InputAction.CallbackContext context)
    {
        StartThrust(context, leftController);
    }

    private void OnLeftTriggerCanceled(InputAction.CallbackContext context)
    {
        StopThrust(context, leftController);
    }

    private void OnRightTriggerPerformed(InputAction.CallbackContext context)
    {
        StartThrust(context, rightController);
    }

    private void OnRightTriggerCanceled(InputAction.CallbackContext context)
    {
        StopThrust(context, rightController);
    }

    void StartThrust(InputAction.CallbackContext context, GameObject controller)
    {
        isThrusting = true;
        activeController = controller;
    }

    void StopThrust(InputAction.CallbackContext context, GameObject controller)
    {
        isThrusting = false;
        activeController = null;
    }
}