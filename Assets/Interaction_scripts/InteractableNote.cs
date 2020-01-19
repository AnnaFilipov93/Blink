using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractableNote : BaseInteractableObject
{

    [SerializeField]
    GameObject note=null;
   
    void Start()
    {
        interact_tip = "Press E to read note";
    }
    public override void ClickedInteraction()
    {
        if (Time.timeScale == 0)
        {
            interact_tip = "Press E to read note";
            Time.timeScale = 1;
            note.transform.localScale = new Vector3(1, 0, 1);
           
        }
        else {
            Time.timeScale = 0;
            interact_tip = "Press E to exit";
            note.transform.localScale = new Vector3(1, 1, 1);
            
        }
        
    }

    

   
}
