using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame(){
        PlayerPrefs.DeleteKey("username");
        PlayerPrefs.DeleteKey("scoreText");
        SceneManager.LoadScene("GameStart");
    }
}
