using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===== SoundType enum delcaration that holds "HIT" and "LAVA" values
public enum SoundType
{
    HIT = 0,
    LAVA = 1,
}

public class SoundScript : MonoBehaviour
{
    // ===== Variable declaration to hold reference to AudioSource class component array named "MyAudioSources"
    //public AudioSource[] MyAudioSources;

    // ===== Start is called before the first frame update
    void Start()
    {
        // ===== Call MyPlaySound function when the game first starts up
        //MyPlaySound(SoundType.LAVA);
    }

    // ===== Update is called once per frame
    void Update()
    {
        
    }

    // ===== Declare function named "MyPlaySound"
    public void MyPlaySound(SoundType mySoundType)
    {
        // ===== Get the AudioSource component class from the "MyAudioSources" array, and call the "Play" function to hear the sound
        //MyAudioSources[(int)mySoundType].Play();
    }
}
