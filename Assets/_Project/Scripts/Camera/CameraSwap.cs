using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    [SerializeField] private GameObject camera2D, camera3D;
    private bool current3D;

    void Update()
    {
      CameraState();
    }

    private void CameraState()
    {
      if(Mode.mode3D && !current3D)
      {
        camera2D.SetActive(false);
        camera3D.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        current3D = true;
      } else if(!Mode.mode3D && current3D)
      {
        camera3D.SetActive(false);
        camera2D.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        current3D = false;
      }
    }
}
