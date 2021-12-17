using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

    public InputField userName;
    public void getUsername(){
        PlayerPrefs.SetString("username", userName.text);
    }

    public void clickStart(){
        SceneManager.LoadScene("Game");
    }
}
