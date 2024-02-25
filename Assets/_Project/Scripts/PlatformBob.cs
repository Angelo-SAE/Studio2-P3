using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBob : MonoBehaviour
{
    public float bobbingSpeed;
    public float bobbingHeight;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        
        float newY = Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight + startPosition.y;

        
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
