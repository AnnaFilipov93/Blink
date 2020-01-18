using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{

    [SerializeField]
    GameObject player=null;

    [SerializeField]
    float speed =1f;
    [SerializeField]
    float shineTimer =0;

    [SerializeField]
    bool isNegativeStatue = false;

    public float timeSinceShine = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (shineTimer == 0) shineTimer = 10f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceShine += Time.deltaTime;

        if (!isNegativeStatue && timeSinceShine < shineTimer) return;
        if (isNegativeStatue && timeSinceShine > 0.4f) return;
        var heading = player.transform.position - this.transform.position;
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading / distance; // This is now the normalized direction.
       
        transform.forward = new Vector3(direction.x, direction.y, direction.z);
        transform.Translate(Vector3.forward* Time.deltaTime*speed);
        

        /*if (heading.sqrMagnitude < maxRange * maxRange)
        {
            // Target is within range.
        }*/


    }


}
