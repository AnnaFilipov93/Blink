using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightBatteries : MonoBehaviour
{

    float charge = 101;

    [SerializeField]
    float time_fraction = 0.1f;

    [SerializeField]
    GameObject flashlight=null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        charge -= Time.deltaTime * time_fraction;
        charge = Mathf.Max(charge, 0);
        GetComponent<Text>().text = ((int)charge) + "% Battery";

        if (charge-5*Random.value < 1)
        {
            flashlight.SetActive(false);
        }
        else {
            flashlight.SetActive(true);
        }
    }

    public void addCharge(float amount) {
        charge = Mathf.Min(charge + amount, 101);
    }
}
