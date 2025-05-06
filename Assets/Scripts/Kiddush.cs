using UnityEngine;

public class Kiddush : MonoBehaviour
{
    [SerializeField] private AudioClip prayerClip;
    private AudioSource audioSource;
    private SynagogueAudioManager synagogueAudioManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        synagogueAudioManager = FindObjectOfType<SynagogueAudioManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public void UseKiddushCup()
    {
        if (prayerClip != null)
        {
            synagogueAudioManager.TurnOffAllSounds();
            audioSource.clip = prayerClip;
            audioSource.Play();
        }
    }
}
