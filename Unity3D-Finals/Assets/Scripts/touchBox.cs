using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class touchBox : MonoBehaviour
{
    private int count;
    public Text score;
    public Text timer;
    float startingTime = 10f;
    void Start()
    {
        count = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
            
        if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                if (hit.transform.tag == "box"){
                    Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                    hit.collider.GetComponent<MeshRenderer>().material.color = newColor;
                    count++;
                    score.text = "Score: " + count.ToString();
                }
            }

        }

        startingTime -= 1 * Time.deltaTime;
        timer.text = "Timer : " + startingTime.ToString("00");

        if(startingTime < 0 ){
            PlayerPrefs.SetString("scoreText", score.text);
            SceneManager.LoadScene("GameEnd");
        }
            
    }
}
