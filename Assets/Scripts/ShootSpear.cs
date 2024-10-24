using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpear : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;
    public GameObject Spear;
    public float shootPower = 500f;
    public LineRenderer spearLine;

    public InputActionReference trigger;
    public InputActionReference reelTrigger;

    private GameObject currentSpear;
    private GameObject previousSpear;

    public float moveSpeed = 10f;
    public float reelDrag = 5f; // Increased drag for reeling
    public float reelSpeedMultiplier = 0.5f; // Slower speed while reeling

    private Vector3 velocity;

    void Start()
    {
        trigger.action.performed += Shoot;
        trigger.action.canceled += StopAiming;
       
        //reelTrigger.action.performed += ReelIn;
        spearLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (currentSpear != null)
        {
            UpdateLineRenderer(currentSpear.transform.position);

            if (reelTrigger.action.IsPressed())
            {
                ReelIn();
            }
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
        // spearLine.enabled = false; // Comment this out to keep it active
    }

    void UpdateLineRenderer(Vector3 spearPosition)
    {
        
        spearLine.SetPosition(0, transform.position); 
        spearLine.SetPosition(1, spearPosition); 
    }
    void ReelIn()//InputAction.CallbackContext _)
    {
        if (currentSpear.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            //Vector3 directionToSpear = (currentSpear.transform.position - playerOrigin.transform.position).normalized;
            //playerOrigin.transform.position += directionToSpear * Time.deltaTime * moveSpeed;

            Vector3 directionToSpear = (currentSpear.transform.position - playerOrigin.transform.position).normalized;
            Vector3 targetVelocity = directionToSpear * moveSpeed * reelSpeedMultiplier;

            // Apply drag effect
            velocity = Vector3.Lerp(velocity, targetVelocity, Time.deltaTime * reelDrag);
            playerOrigin.transform.position += velocity * Time.deltaTime;
        }
    }

    private void OnDestroy()
    {
        spearLine.enabled = false;
    }
}
