using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetFloor : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
      if(col.tag == "Player")
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
