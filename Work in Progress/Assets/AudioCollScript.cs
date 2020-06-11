using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollScript : MonoBehaviour
{

    public GameObject Coll;
    public string SFX;
    public bool AudioTrigger;

    private AudioSource[] allAudioSources;

    private void Start()
    {
        AudioTrigger = true;
    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        StopAllAudio();

        if (AudioTrigger == true)
        {
            SoundManagerScript.PlaySound(SFX);
            AudioTrigger = false;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        AudioTrigger = true;
        Destroy(Coll);
    }
}
