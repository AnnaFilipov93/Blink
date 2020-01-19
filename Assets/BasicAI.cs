using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicAI : MonoBehaviour
{

    [SerializeField]
    GameObject player=null;

    [SerializeField]
    float speed =7f;
    [SerializeField]
    float shineTimer =0;

    [SerializeField]
    bool isNegativeStatue = false;
    
    [SerializeField]
    Animator animation = null;

    float maxRange = 1.111f;
    float activeDistance = 111f;

    public float timeSinceShine = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (shineTimer == 0) shineTimer = 10f * Random.value;
        if (animation == null) animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = Mathf.Max(0 ,GetComponent<AudioSource>().volume-Time.deltaTime);
        timeSinceShine += Time.deltaTime;
        if ((!isNegativeStatue && timeSinceShine < shineTimer) || (isNegativeStatue && timeSinceShine > 0.42f)) {
            animation.speed = 0;
            animation.SetBool("canMove", false);
            return; 
        }
        animation.speed = 1;
        animation.SetBool("canMove", true);
        var heading = player.transform.position - this.transform.position;
        if (heading.sqrMagnitude < activeDistance * activeDistance)
        {
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading / distance; // This is now the normalized direction.
       
        transform.forward = new Vector3(direction.x, direction.y, direction.z);
        transform.Translate(Vector3.forward* Time.deltaTime*speed);

        GetComponent<AudioSource>().volume = 1;

        if (heading.sqrMagnitude < maxRange * maxRange)
        {
            SceneManager.LoadScene("FinalLost");
        }

        }

    }


}
