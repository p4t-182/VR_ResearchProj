using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpear : MonoBehaviour
{
    public GameObject Spear;
    public float shootPower = 500f;
    public LineRenderer spearLine;

    public InputActionReference trigger;

    private GameObject currentSpear;
    private GameObject previousSpear;

    void Start()
    {
        trigger.action.performed += Shoot;
        trigger.action.canceled += StopAiming;
        spearLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (currentSpear != null)
        {
            UpdateLineRenderer(currentSpear.transform.position);
        }
    }

    void Shoot(InputAction.CallbackContext _)
    {

        if (previousSpear != null)
        {
            Destroy(previousSpear);
            currentSpear = Instantiate(Spear, transform.position, transform.rotation);
            currentSpear.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
            previousSpear = currentSpear;
        }
        else
        {
            currentSpear = Instantiate(Spear, transform.position, transform.rotation);
            currentSpear.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
            previousSpear = currentSpear;
        }

            
        spearLine.enabled = true;
        spearLine.positionCount = 2;
        spearLine.SetPosition(0, transform.position); 
        spearLine.SetPosition(1, currentSpear.transform.position); 
        
    }

    void StopAiming(InputAction.CallbackContext _)
    {
        // Optionally, you can keep the line renderer active and just update it
        // spearLine.enabled = false; // Comment this out to keep it active
    }

    void UpdateLineRenderer(Vector3 spearPosition)
    {
        
        spearLine.SetPosition(0, transform.position); 
        spearLine.SetPosition(1, spearPosition); 
    }

    private void OnDestroy()
    {
        spearLine.enabled = false;
    }
}
