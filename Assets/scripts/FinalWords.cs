using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinalWords : MonoBehaviour
{
    float timePassed = 0;
    int child = 0;
    void Update()
    {
        timePassed += Time.deltaTime;
        if (child == this.transform.childCount) {
            if (timePassed >= 4) {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else { 
        Color c = this.transform.GetChild(child).GetComponent<Text>().color;
        this.transform.GetChild(child).GetComponent<Text>().color = new Color(c.r,c.g,c.b,timePassed/1.5f);
        if (timePassed >=2f) {
            child++;
            timePassed = 0;
        }
        }
    }
}
