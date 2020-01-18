using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableKey : BaseInteractableObject
{
    public static bool haveBarnKey = false;
    public override void ClickedInteraction()
    {
        haveBarnKey = true;
        Destroy(this.transform.gameObject, 0);
    }

}
