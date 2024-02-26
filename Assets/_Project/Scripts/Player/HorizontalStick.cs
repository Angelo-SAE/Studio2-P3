using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalStick : MonoBehaviour
{
    [SerializeField] private float detectionRange;
    private bool hasParent;
    private GameObject groundObject;
    RaycastHit hit;

    void Update()
    {
        DetectFloor();
        MakeParent();
    }

    private void DetectFloor()
    {
        Physics.Raycast(transform.position, -Vector3.up, out hit, detectionRange, 1 << 6);
        if (hit.transform != null)
        {
            groundObject = hit.transform.gameObject;
        }
    }

    private void MakeParent()
    {
        
        if (!hasParent && groundObject != null)
        {
            transform.SetParent(groundObject.transform);
            hasParent = true;
        }
    }
}
