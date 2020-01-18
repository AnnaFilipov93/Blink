using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuExit : MenuAction
{
    public override void act()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
