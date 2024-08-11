using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class Discovernumbers : MonoBehaviour
{
    public GameObject Number_Two_Character;
    public AudioSource TwoSound;
    public AudioSource ThreeSound;
    public AudioSource OneSound;
    public float Pllay = 0;
   
    private void OnTriggerEnter(Collider other)
    {
  

        if (other.gameObject.tag == "One" || other.gameObject.tag == "Onee" || other.gameObject.tag == "Oneee" && OneSound.isPlaying)
        {
            OneSound.Stop();
          

            if (Pllay == 0)
            {
                other.gameObject.SetActive(false);
                Pllay = 1;
                TwoSound.Play();
            }
           
        }


        if (other.gameObject.tag == "Two" || other.gameObject.tag == "Twoo" || other.gameObject.tag == "Twooo")
        {
            TwoSound.Stop();


            if (Pllay == 1)
            {
                other.gameObject.SetActive(false);
                Pllay = 2;
                ThreeSound.Play();
            }

        }



        if (other.gameObject.tag == "Thre" || other.gameObject.tag == "Three" || other.gameObject.tag == "Threee" || other.gameObject.tag == "Threeeee")
        {
            ThreeSound.Stop();


            if (Pllay == 2)
            {
                other.gameObject.SetActive(false);
                Pllay = 1;
                OneSound.Play();
            }

        }

        if (other.gameObject.tag == "Thre" & other.gameObject.tag == "Three" & other.gameObject.tag == "Threee" & other.gameObject.tag == "Threeeee")
        {
            OneSound.Stop();

        }



    }
    
}
