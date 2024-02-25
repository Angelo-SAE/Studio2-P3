using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public float maxUp, maxDown, maxRight, maxLeft;
    [SerializeField] private bool isStick;
    private Collider col;
    private bool triggerDown;

    void Start()
    {
      col = GetComponentInChildren<Collider>();
    }

    void Update()
    {
      if(!isStick)
      {
        CheckForModeChange();
      }

    }

    private void CheckForModeChange()
    {
      if(Mode.mode3D && triggerDown)
      {
        DisableEnableCollider();
        triggerDown = false;
      } else if(!Mode.mode3D && !triggerDown)
      {
        DisableEnableCollider();
        triggerDown = true;
      }
    }


    private void DisableEnableCollider()
    {
      if(triggerDown)
      {
        col.enabled = true;
      } else if(!triggerDown)
      {
        col.enabled = false;
      }

    }
}
