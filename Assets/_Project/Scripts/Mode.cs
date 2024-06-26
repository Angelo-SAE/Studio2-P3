using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{

    public static bool mode3D;

    void Awake()
    {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
      mode3D = true;
    }

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.R))
      {
        ChangeMode();
      }
    }

    private void ChangeMode()
    {
      if(mode3D)
      {
        mode3D = false;
      } else {
        mode3D = true;
      }
    }
}
