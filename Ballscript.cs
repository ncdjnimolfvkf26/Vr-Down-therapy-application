using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    public GameObject Target;
    public AudioClip OneSound;
    public AudioClip TwoSound;
    public AudioClip ThreeSound;
    public GameObject NumberOne;
    public GameObject NumberTwo;
    public GameObject NumberThree;
    public GameObject football1;
    public GameObject football2;
    public GameObject football3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foot1")
        {
            other.gameObject.transform.SetParent(Target.transform);
            other.gameObject.transform.position = Target.transform.position;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(OneSound);
            NumberOne.gameObject.transform.position = new Vector3(0, 2, 8);
            football2.gameObject.transform.position = new Vector3(-0.73f, .96f, 1.37f);
            
        }

        if (other.gameObject.tag == "Foot2")
        {
            other.gameObject.transform.SetParent(Target.transform);
            other.gameObject.transform.position = Target.transform.position;
           Camera.main.GetComponent<AudioSource>().PlayOneShot(TwoSound);
            NumberTwo.gameObject.transform.position = new Vector3(-0.36f, 1.84f, 8.4f);
            football3.gameObject.transform.position = new Vector3(3.55f, 0.69f, 3.62f);
            NumberOne.gameObject.SetActive(false);
            
        }

        if (other.gameObject.tag == "Foot3")
        {
            other.gameObject.transform.SetParent(Target.transform);
            other.gameObject.transform.position = Target.transform.position;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(ThreeSound);
            NumberThree.gameObject.transform.position = new Vector3(0.04f, 1.96f, 9.31f);
            NumberTwo.gameObject.SetActive(false);
        }
    }
         
}


   
