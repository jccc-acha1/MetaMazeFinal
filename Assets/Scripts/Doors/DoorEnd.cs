using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DoorEnd : MonoBehaviour
{
    public GameObject handKey;
    public GameObject gameWinText;
    [SerializeField] private PostProcessVolume postProcessing;
    LensDistortion lensDistLayer;

    private void Start()
    {
        postProcessing.profile.TryGetSettings(out lensDistLayer);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && FirstPersonController.keyNum == 4)
        {
            handKey.SetActive(false);

            // Side Effect
            lensDistLayer.active = false;
            gameWinText.SetActive(true);

            Destroy(gameObject);
        }
    }
}
