using UnityEngine;
using System.Collections;

public class ConeColliderShine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider other)
    {
        ShineReset(other.gameObject);
    }

    void OnTriggerStay(Collider other)
    {
        ShineReset(other.gameObject);
    }

    void ShineReset(GameObject hit) {
        if (!hit.tag.StartsWith("Enemy")) return;
        var ai = hit.transform.GetComponent<BasicAI>();
        if (ai)
        {
            ai.timeSinceShine = 0;
        }
    }
}
