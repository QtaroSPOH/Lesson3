using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    [Range(0, 100)]
    public float speedFactor = 4.3f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ThirdPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<ThirdPersonMovement>().runSpeed /= speedFactor;
    }
}
