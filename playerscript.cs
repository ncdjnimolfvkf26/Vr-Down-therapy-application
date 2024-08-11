using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour

{
    public float speed = 5;
    public GameObject PlayerHands;
    public AudioClip OneSound;
    public AudioClip TwoSound;
    public AudioClip ThreeSound;




    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            this.transform.position += Camera.main.transform.forward * speed * Time.deltaTime;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "One")
        {


            Camera.main.GetComponent<AudioSource>().PlayOneShot(OneSound);
        }

        if (other.gameObject.tag == "Two")
        {


            Camera.main.GetComponent<AudioSource>().PlayOneShot(TwoSound);
        }

        if (other.gameObject.tag == "Three")
        {


            Camera.main.GetComponent<AudioSource>().PlayOneShot(ThreeSound);
        }

    }

}



