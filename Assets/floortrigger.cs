using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floortrigger : MonoBehaviour
{
    public GameObject telepport;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = telepport.transform.position;
        }

    }
}
