using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public GameObject handKey;
    public GameObject memesImage;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && FirstPersonController.keyNum == 2)
        {
            handKey.SetActive(false);

            // Side Effect
            memesImage.SetActive(true);

            Destroy(gameObject);
        }
    }
}
