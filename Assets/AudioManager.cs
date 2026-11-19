
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip overworldMusic;
    public AudioClip caveMusic;

    public AudioClip[] variousSFX;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        musicSource.clip = overworldMusic;
        musicSource.Play();
    }

    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip sound)
    {
        sfxSource.PlayOneShot(sound);
    }

    public void PlayRandomSFX(AudioClip[] audioClips)
    {
        int randomIndex = Random.Range(0, audioClips.Length);

        AudioClip randomClip = audioClips[randomIndex];

        sfxSource.PlayOneShot(randomClip);
    }
}
