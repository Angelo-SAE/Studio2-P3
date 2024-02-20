using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    [SerializeField] private GameObject camera2D, camera3D;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        CameraState();
      }
    }

    private void CameraState()
    {
      if(Mode.mode3D)
      {
        camera2D.SetActive(true);
        camera3D.SetActive(false);
      } else {
        camera3D.SetActive(true);
        camera2D.SetActive(false);
      }
    }
}
