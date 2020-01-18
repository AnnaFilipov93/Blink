using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MenuAction
{

    [SerializeField]
    string scene;
    public override void act()
    {
        SceneManager.LoadScene(scene);
    }
}
