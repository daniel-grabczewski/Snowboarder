using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    
     void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.CompareTag("Ground"))
      {
        Debug.Log("You hit your head!");
        Invoke(nameof(ReloadScene), loadDelay);
      } 
    }

    void ReloadScene() {
      SceneManager.LoadScene("Level1");
    }
}
