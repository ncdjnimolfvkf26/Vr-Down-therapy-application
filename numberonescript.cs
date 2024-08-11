using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using UnityEngine;

public class numberonescript : MonoBehaviour
{
    public AudioClip CollectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {

           
        }

    }
}

