using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInteractableObject : MonoBehaviour
{
    [SerializeField]
    internal string interact_tip="";

    
    void Start()
    {
        this.tag = "Interactable";
    }

    public abstract void ClickedInteraction();
    public void InteractionLogic() {
        if (Input.GetKeyDown(KeyCode.E)) {
            ClickedInteraction();
        }
    }
}
