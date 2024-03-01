using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDFog : MonoBehaviour
{

    private GameObject fog;
    private bool fogAlive, fogActive;

    void Start()
    {
      fogAlive = true;
      fogActive = true;
      fog = transform.GetChild(0).gameObject;
    }

    void Update()
    {
      DisableEnableFog();
    }

    private void DisableEnableFog()
    {
      if(Mode.mode3D && fogAlive && fogActive)
      {
        fog.SetActive(false);
        fogActive = false;
      } else if(!Mode.mode3D && fogAlive && !fogActive)
      {
        fog.SetActive(true);
        fogActive = true;
      }
    }

    private void OnTriggerEnter(Collider col)
    {
      if(col.tag == "Player" && fogAlive)
      {
        fog.SetActive(false);
        fogAlive = false;
        Destroy(gameObject);
      }
    }
}
