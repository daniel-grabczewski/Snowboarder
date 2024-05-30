using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;

    void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.CompareTag("Player"))
      {
        Debug.Log("You finished!");
        Invoke(nameof(ReloadScene), loadDelay);
      } 
    }

    void ReloadScene() {
      SceneManager.LoadScene("Level1");
    }
}
