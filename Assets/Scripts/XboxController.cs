﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class XboxController : MonoBehaviour {

    public GameObject canvas;
    public Button buttonA;
    public Button buttonB;
    public Button buttonX;
    public Button buttonY;

    // Use this for initialization
    void Start () {
		
	}

    void OnButtonClick()
    {
        var go = EventSystem.current.currentSelectedGameObject;
        if (go != null)
        {
            Debug.Log(go.GetComponentInChildren<Text>().text);
            if (canvas.GetComponent<RandomQuestions>().getAnswer(canvas.GetComponent<RandomQuestions>().answer, go.GetComponentInChildren<Text>().text))
                Debug.Log("Good!");
            else
                Debug.Log("Wrong!");
        }
        else
            Debug.Log("null");
    }

    /*
    public void ButtonAClicked()
    {
        Debug.Log("A Pressed");
        //return this.GetComponent<Text>().text;
        
    }
    public void ButtonBClicked()
    {
        Debug.Log("B Pressed");
    }
    public void ButtonXClicked()
    {
        Debug.Log("X Pressed");
    }
    public void ButtonYClicked()
    {
        Debug.Log("Y Pressed");
    }
    */

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.Joystick1Button0)){
            EventSystem.current.SetSelectedGameObject(null);
            buttonA.Select();
            buttonA.onClick.Invoke();
            EventSystem.current.SetSelectedGameObject(null);
        }
        
        else if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            EventSystem.current.SetSelectedGameObject(null);
            buttonB.Select();
            buttonB.onClick.Invoke();
            EventSystem.current.SetSelectedGameObject(null);
        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            EventSystem.current.SetSelectedGameObject(null);
            buttonX.Select();
            buttonX.onClick.Invoke();
            EventSystem.current.SetSelectedGameObject(null);

        }
        else if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            EventSystem.current.SetSelectedGameObject(null);
            buttonY.Select();
            buttonY.onClick.Invoke();
            EventSystem.current.SetSelectedGameObject(null);

        }
        

    }
}