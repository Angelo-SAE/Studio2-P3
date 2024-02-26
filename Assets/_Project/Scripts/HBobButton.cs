using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBobButton : MonoBehaviour
{
    public GameObject floor;
    PlatformBob bob;
    void Start()
    {
        bob = floor.GetComponent<PlatformBob>();
        bob.isHBobbing = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            bob.isHBobbing = true;
            Destroy(gameObject);
        }
    }


}
