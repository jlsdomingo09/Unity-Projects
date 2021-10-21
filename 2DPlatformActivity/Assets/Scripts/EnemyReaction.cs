using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyReaction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Enemy")) {
            SceneManager.LoadScene ("GameOver");
        }
        
    }
}
