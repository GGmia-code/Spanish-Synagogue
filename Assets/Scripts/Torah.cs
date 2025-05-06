using UnityEngine;

public class Torah : MonoBehaviour
{

    [SerializeField] private AudioClip prayerReading;
    private AudioSource audioSource;

    private SynagogueAudioManager synagogueAudioManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        synagogueAudioManager = FindObjectOfType<SynagogueAudioManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTorahReading()
    {
        if (prayerReading != null)
        {
            synagogueAudioManager.TurnOffAllSounds();
            Debug.Log("Torah Pressed");
            audioSource.clip = prayerReading;
            audioSource.Play();
        }

    }
}