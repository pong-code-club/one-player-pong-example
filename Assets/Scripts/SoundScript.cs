using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    HIT = 0,
    LAVA = 1,
}

public class SoundScript : MonoBehaviour
{
    public AudioSource[] MyAudioSources;
    // Start is called before the first frame update
    void Start()
    {
        MyPlaySound(SoundType.LAVA);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyPlaySound(SoundType mySoundType)
    {
        MyAudioSources[(int)mySoundType].Play();
    }
}
