using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    public float mainMenuVolume;
    public static MusicManager instance;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        audioMixer.SetFloat("Volume", 0);
    }

    public void SetVolume(float volume)
    {
        volume = slider.value;
        mainMenuVolume = slider.value;
        audioMixer.SetFloat("Volume", volume);
    }
}
