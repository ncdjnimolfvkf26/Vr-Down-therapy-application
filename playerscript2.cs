using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript2 : MonoBehaviour

{
    public float speed = 5;
    public GameObject PlayerHands;
    public GameObject ObjectInMyHands;
    public AudioClip OneSound;
    public AudioClip TwoSound;
    public AudioClip ThreeSound;
    public float number = 0;



    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            this.transform.position += Camera.main.transform.forward * speed * Time.deltaTime;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            other.gameObject.transform.SetParent(PlayerHands.transform);
            other.gameObject.transform.position = PlayerHands.transform.position;
            ObjectInMyHands = other.gameObject;
            number = number + 1;
        }

       

        if (other.gameObject.tag == "Box" )
        {
            
            other.gameObject.transform.position = PlayerHands.transform.position;
            ObjectInMyHands.transform.SetParent(null);
            ObjectInMyHands.transform.position = other.gameObject.transform.position + new Vector3(0, .5f, 0);
            ObjectInMyHands.tag = "BallDown";
            ObjectInMyHands.GetComponent<Collider>().isTrigger = false;
            ObjectInMyHands.GetComponent<Renderer>().material.color = Color.red;
            
            

            if (number == 1)
            {
           
                Camera.main.GetComponent<AudioSource>().PlayOneShot(OneSound);
                
            }
            if (number == 2)
            {

                Camera.main.GetComponent<AudioSource>().PlayOneShot(TwoSound);
               
            }
            if (number == 3)
            {

                Camera.main.GetComponent<AudioSource>().PlayOneShot(ThreeSound);
                
            }
        }


    }

}


