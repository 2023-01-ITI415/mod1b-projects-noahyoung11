using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text timeGT;
    
    public float timeLeft = 5;
    
    void Start(){
        GameObject timeGO = GameObject.Find("TimerText");
        timeGT = timeGO.GetComponent<Text>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if(timeLeft >= 0){
            timeLeft -= Time.deltaTime;
        }else{
            SceneManager.LoadScene("Main-Prototype 1");
        }
        timeGT.text = "Time Remaining: " + timeLeft;
    }
}
