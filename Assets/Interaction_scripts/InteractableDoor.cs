using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : BaseInteractableObject
{
    bool opened = false;
    public override void ClickedInteraction()
    {
        if (InteractableKey.haveBarnKey) {
            if (opened) {
                interact_tip = "Press E to open";
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else {
                interact_tip = "Press E to close";
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            opened = !opened;

        }
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
