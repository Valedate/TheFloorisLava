using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hold : MonoBehaviour
{
    // Start is called before the first frame update
    public Material red;
    public Material blue;
    public GameObject platform;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag =="Player") {
            platform.transform.GetComponent<Renderer>().material = blue;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") {
            platform.transform.GetComponent<Renderer>().material = red;
        }

    }

}
