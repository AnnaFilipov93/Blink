using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PandoraBox : BaseInteractableObject
{
    [SerializeField]
     Animator animator;
    public override void ClickedInteraction()
    {
        animator.SetTrigger("closing");
        
       // SceneManager.LoadScene("Final");
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
