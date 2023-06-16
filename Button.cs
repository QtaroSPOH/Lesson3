using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator door;
    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false;
        door.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        door.enabled = true;
    }
}
