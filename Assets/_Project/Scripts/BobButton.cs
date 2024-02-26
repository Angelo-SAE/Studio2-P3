using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobButton : MonoBehaviour
{
    public GameObject floor;
    PlatformBob bob;
    void Start()
    {
        bob = floor.GetComponent<PlatformBob>();
        bob.isBobbing = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            bob.isBobbing = true;
            Destroy(gameObject);
        }
    }

    
}
