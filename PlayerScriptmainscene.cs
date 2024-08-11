using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;
public class PlayerScriptmainscene : MonoBehaviour
{
    public float speed = 5;
    public GameObject PlayerHands;




   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sceneone")
        {
          //  other.gameObject.transform.SetParent(PlayerHands.transform);
            SceneManager.LoadScene("Scene5");
            //other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Scenetwo")
        {
            SceneManager.LoadScene("Scene5");

        }
        if (other.gameObject.tag == "Scenethree")
        {

            SceneManager.LoadScene("Scene5");
        }

    }*/


    public void OnCollisionEnter( Collision gameObjectInformation)
    {
        if (gameObjectInformation.gameObject.name == "player")
        {
            SceneManager.LoadScene("Scene5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            this.transform.position += Camera.main.transform.forward * speed * Time.deltaTime;

        }
    }

}