using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBob : MonoBehaviour
{
    public float bobbingSpeed;
    public float bobbingHeight;

    public float bobbingSpeedHorizontal;
    public float bobbingHeightHorizontal;

    public bool isBobbing = true;
    public bool isHBobbing = true;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isBobbing && isHBobbing) 
        {
            float newY = Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight + startPosition.y;
            float newZ = Mathf.Sin(Time.time * bobbingSpeedHorizontal) * bobbingHeightHorizontal + startPosition.z;


            transform.position = new Vector3(startPosition.x, newY, newZ);

        }
        
        if (isBobbing && !isHBobbing)
        {
            float newY = Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight + startPosition.y;


            transform.position = new Vector3(startPosition.x, newY, startPosition.z);
        }

        else if (isHBobbing && !isBobbing)
        {
            float newZ = Mathf.Sin(Time.time * bobbingSpeedHorizontal) * bobbingHeightHorizontal + startPosition.z;


            transform.position = new Vector3(startPosition.x, startPosition.y, newZ);
        }
    }
}
