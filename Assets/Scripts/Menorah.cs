using UnityEngine;

public class Menorah : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject fireFXPrefab;
    [SerializeField] private AudioClip fireIgnitionClip;
    private AudioSource audioSource;
    private SynagogueAudioManager synagogueAudioManager;

    private bool isLit = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        synagogueAudioManager = FindObjectOfType<SynagogueAudioManager>();

        audioSource = GetComponent<AudioSource>();
        fireFXPrefab.SetActive(false);
        audioSource.clip = fireIgnitionClip;
    }

    public void LightCandles()
    {
        if (!isLit)
        {
            fireFXPrefab.SetActive(true);
            synagogueAudioManager.TurnOffAllSounds();
            audioSource.Play();
            isLit = true;
        }
    }
}
