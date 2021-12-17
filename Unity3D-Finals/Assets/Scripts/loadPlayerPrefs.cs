using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadPlayerPrefs : MonoBehaviour
{

    public Text userNameBox;
    public Text scoreBox;
    void Start() {
        userNameBox.text = "Username: " + PlayerPrefs.GetString("username");
        scoreBox.text = PlayerPrefs.GetString("scoreText");
    }
}
