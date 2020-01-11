using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{

    [SerializeField]
    GameObject player=null;

    [SerializeField]
    float speed =1f;

   public float timeSinceShine = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceShine += Time.deltaTime;

        if (timeSinceShine < 5) return;
        var heading = player.transform.position - this.transform.position;
        heading.y = 0;
        var distance = heading.magnitude;
        var direction = heading / distance; // This is now the normalized direction.

        transform.Translate(heading.normalized * speed * Time.deltaTime);

        /*if (heading.sqrMagnitude < maxRange * maxRange)
        {
            // Target is within range.
        }*/


    }


}
