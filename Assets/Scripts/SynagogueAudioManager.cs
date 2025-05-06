using UnityEngine;
using Unity;
using System.Collections.Generic;

public class SynagogueAudioManager : MonoBehaviour
{

    public static SynagogueAudioManager instance;
    
    //[SerializeField] private List<AudioSource> audiosources = new List<AudioSource>();
    [SerializeField] private AudioSource[] audiosources;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audiosources = FindObjectsOfType<AudioSource>();
    }

    public void TurnOffAllSounds()
    {
        for (int i = 0; i < audiosources.Length; i++)
        {
            audiosources[i].Stop();
        }
    }

}
