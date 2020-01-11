using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectInteractor : MonoBehaviour
{

    [SerializeField]
    float Interactable_distance = 4;
    [SerializeField]
    Text interactable_text=null;
    void Start()
    {
        
    }

    void Update()
    {
        

        string interact_tip = "";
        RaycastHit[] hits;

        hits = Physics.RaycastAll(transform.position, transform.forward, Interactable_distance);
        Debug.DrawLine(transform.position, transform.position + transform.forward * Interactable_distance, Color.red);
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            var interactable = hit.transform.GetComponent<BaseInteractableObject>();
            if (interactable)
            {
                interact_tip = interactable.interact_tip;
                interactable.InteractionLogic();
            }
        }
       
        interactable_text.text = interact_tip;
        
    }
}
