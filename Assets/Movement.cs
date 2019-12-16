using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    [SerializeField]
    public Animator animator;

    [SerializeField]
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + Input.GetAxis("Horizontal"), 0);

       // transform.position += move * speed * Time.deltaTime;
        transform.Translate(move * speed * Time.deltaTime, Space.Self);
        animator.SetFloat("speed",Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical")));
       
    }
}
