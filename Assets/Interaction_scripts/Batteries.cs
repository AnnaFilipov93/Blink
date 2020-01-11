using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batteries : BaseInteractableObject
{


    public override void ClickedInteraction()
    {
        FlashlightBatteries flashlight = (FlashlightBatteries)FindObjectOfType(typeof(FlashlightBatteries));
        flashlight.addCharge(6);
        Destroy(this.gameObject, 0);
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
