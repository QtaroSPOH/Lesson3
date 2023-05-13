using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    [Range(0, 100)]
    public float stregnthFactor = 4.3f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= stregnthFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= stregnthFactor;
    }
}
