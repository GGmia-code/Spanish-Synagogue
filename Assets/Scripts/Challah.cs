using UnityEngine;

public class Challah : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private AudioSource audioSource;
    private SynagogueAudioManager synagogueAudioManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        synagogueAudioManager = FindObjectOfType<SynagogueAudioManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public void UseChallah()
    {
        synagogueAudioManager.TurnOffAllSounds();
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
