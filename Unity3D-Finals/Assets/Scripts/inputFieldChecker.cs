using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputFieldChecker : MonoBehaviour
{
    // Start is called before the first frame updat
    public Text uName;
    public Button button;
    void Start(){
        button.enabled = false;
    }

    void Update(){
        if(uName.text == "")
            button.enabled = false;
        else if(uName.text != "")
            button.enabled = true;

    }
}
