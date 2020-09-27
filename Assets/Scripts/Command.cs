using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;


public class Command : MonoBehaviour
{
    public InputField input;
    private Canvas CanvasObject;
    public Vector3 vec;

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
    }


    public void UserCommand(string theCommand)
    {

        theCommand = input.text;
        //Debug.Log(theCommand);

        if (theCommand.ToLower() == "exit")
        {
            CanvasObject.enabled = false;
            theCommand = "";
            Time.timeScale = 1;
        }

        if (theCommand.ToLower().StartsWith("backgroundcolor:"))
        {
            string color = theCommand.Substring(16);
            //Debug.Log(color);
            if (color.ToLower() == "black")
            {
                Camera.main.backgroundColor = Color.black;
            }
            else if (color.ToLower() == "blue")
            {
                Camera.main.backgroundColor = Color.blue;
            }
            else if (color.ToLower() == "clear")
            {
                Camera.main.backgroundColor = Color.clear;
            }
            else if (color.ToLower() == "cyan")
            {
                Camera.main.backgroundColor = Color.cyan;
            }
            else if (color.ToLower() == "gray")
            {
                Camera.main.backgroundColor = Color.gray;
            }
            else if (color.ToLower() == "green")
            {
                Camera.main.backgroundColor = Color.green;
            }
            else if (color.ToLower() == "grey")
            {
                Camera.main.backgroundColor = Color.grey;
            }
            else if (color.ToLower() == "magenta")
            {
                Camera.main.backgroundColor = Color.magenta;
            }
            else if (color.ToLower() == "red")
            {
                Camera.main.backgroundColor = Color.red;
            }
            else if (color.ToLower() == "white")
            {
                Camera.main.backgroundColor = Color.white;
            }
            else if (color.ToLower() == "yellow")
            {
                Camera.main.backgroundColor = Color.yellow;
            }
        }

        if (theCommand.ToLower() == "menu")
        {
            SceneManager.LoadScene("menu");
        }

        if (theCommand.ToLower().StartsWith("gamespeed:"))
        {
            string speed = theCommand.Substring(10);
            Debug.Log(speed);
            float fspeed = float.Parse(speed);
            Time.timeScale = fspeed;
            CanvasObject.enabled = false;
            theCommand = "";
        }
    }
}
