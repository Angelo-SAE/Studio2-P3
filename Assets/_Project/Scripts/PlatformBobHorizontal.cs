using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBobHorizontal : MonoBehaviour
{
    public float bobbingSpeed;
    public float bobbingHeight;

    public bool isBobbing = true;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isBobbing)
        {
            float newZ = Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight + startPosition.y;


            transform.position = new Vector3(startPosition.x, startPosition.y, newZ);
        }
        
    }
}
