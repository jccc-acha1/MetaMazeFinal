using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Door3 : MonoBehaviour
{
    public GameObject handKey;
    public GameObject memesImage;
    [SerializeField] private PostProcessVolume postProcessing;
    LensDistortion lensDistLayer;

    private void Start()
    {
        postProcessing.profile.TryGetSettings(out lensDistLayer);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && FirstPersonController.keyNum == 3)
        {
            handKey.SetActive(false);

            // Side Effect
            memesImage.SetActive(false);
            lensDistLayer.active = true;

            Destroy(gameObject);
        }
    }
}
