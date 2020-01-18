using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour
{

    float timeSinceStart = 0;
    // Update is called once per frame
    void Update()
    {
        timeSinceStart += Time.deltaTime+Random.value* Time.deltaTime;
            this.transform.GetChild(0).transform.gameObject.SetActive((flickFunc(timeSinceStart*0.32f) > 0.0));
        
    }

    double flickFunc(float x) {
        return 5*Mathf.Sin(x)+Mathf.Sin(5*x)-3*Random.value;
    }
}
