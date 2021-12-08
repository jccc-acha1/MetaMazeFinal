using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject pauseMenu;
    [SerializeField] private PostProcessVolume postProcessing;
    Bloom bloomLayer;
    AmbientOcclusion ambientOcclusionLayer;


    private void Start()
    {
        postProcessing.profile.TryGetSettings(out ambientOcclusionLayer);
        postProcessing.profile.TryGetSettings(out bloomLayer);
    }

    public void Fullscreen(bool isFullscreen) 
    {
        Screen.fullScreen = isFullscreen;
    }

    public void AmbientOcclusion(bool isAO)
    {
        ambientOcclusionLayer.active = isAO;
    }
    public void Bloom(bool isBloom)
    {
        bloomLayer.active = isBloom;
    }
    public void Back()
    {
        pauseMenu.SetActive(true);
        optionsMenu.SetActive(false);
        
    }
}
