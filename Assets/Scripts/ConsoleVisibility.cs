using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleVisibility : MonoBehaviour
{
    private Canvas CanvasObject;
    public InputField input;

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        var value = input.text;

        if (Input.GetKeyDown(KeyCode.C))
        {
            CanvasObject.enabled = true;
            Time.timeScale = 0;
            value = "";
        }
    }
}
