using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuSwitch : MonoBehaviour
{

    int selection = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int nextSelection = selection;
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            nextSelection++;
            nextSelection = Mathf.Min(this.transform.childCount-1, nextSelection);
        } 
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            nextSelection--;
            nextSelection = Mathf.Max(0, nextSelection);
        }
        if (nextSelection != selection) {
            this.transform.GetChild(nextSelection).GetComponent<Text>().fontSize = 52;
            this.transform.GetChild(selection).GetComponent<Text>().fontSize = 14;
            selection = nextSelection;
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            this.transform.GetChild(nextSelection).GetComponent<MenuAction>().act();
        }
        
    }

    
}
