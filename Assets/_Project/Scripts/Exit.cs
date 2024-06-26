using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    [SerializeField] private string nextScene;
    
    private void OnTriggerEnter(Collider col)
    {
      if(col.tag == "Player")
      {
        SceneManager.LoadScene(nextScene);
      }
    }
}
