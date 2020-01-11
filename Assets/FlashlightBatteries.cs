﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightBatteries : MonoBehaviour
{

    float charge = 101;

    [SerializeField]
    float time_fraction = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        charge -= Time.deltaTime * time_fraction;
        GetComponent<Text>().text = ((int)charge) + "% Battery";
    }

    public void addCharge(float amount) {
        charge = Mathf.Min(charge + amount, 101);
    }
}
