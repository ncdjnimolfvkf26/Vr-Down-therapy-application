using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject AnimeObject;
    public GameObject ThisTrigger;
    public AudioSource GhostSound;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            AnimeObject.GetComponent<Animator>().Play("Dorrr");
            ThisTrigger.SetActive(false);
           // GhostSound.Play(close);

        }
    }
}