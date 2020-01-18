using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuResume : MenuAction
{
    public override void act()
    {
        Time.timeScale = 1;
        PauseOnEsc.isPaused = false;
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
