using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip Take26, Take27;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        Take26 = Resources.Load<AudioClip>("T26");
        Take27 = Resources.Load<AudioClip>("T27");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "T26":
                audioSrc.PlayOneShot(Take26);
                break;
            case "T27":
                audioSrc.PlayOneShot(Take27);
                break;

        }
    }
}
