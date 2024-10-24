using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFX : MonoBehaviour
{

    void Update()
    {
        Vector3 playerPos = transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y - 0.0015f, playerPos.z);
    }
}
