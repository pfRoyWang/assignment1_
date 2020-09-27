using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVisibility : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Game.gameEnd)
            button.gameObject.SetActive(true);
        else
            button.gameObject.SetActive(false);
    }
}
