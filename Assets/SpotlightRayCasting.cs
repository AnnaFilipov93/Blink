using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightRayCasting : MonoBehaviour
{
    float distance = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;

        hits = Physics.RaycastAll(transform.position, transform.forward, distance);
        Debug.DrawLine(transform.position, transform.position +transform.forward* distance, Color.red);
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            var ai = hit.transform.GetComponent<BasicAI>();

            if (ai)
            {
                ai.timeSinceShine = 0;
            }
        }
    }
}
