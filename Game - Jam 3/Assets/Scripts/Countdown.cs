using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    public float timeStart = 15;
    public Text textBox;

	// Use this for initialization
	void Start () {
        textBox.text = timeStart.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if(timeStart <= 0){
            timeStart = 0.0f;
            textBox.text = "Game Over";
            Debug.Log ("QUIT!");
            Application.Quit();
        }
        else{
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
	}
}
