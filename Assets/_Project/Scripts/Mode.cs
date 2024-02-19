using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{

    public static bool mode3D;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
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
