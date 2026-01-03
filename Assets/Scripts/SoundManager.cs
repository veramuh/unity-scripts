using UnityEngine;
using System.Collections.Generic;
using Mgr.Sound;


public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioClip[] sounds;
    private Dictionary<string, AudioClip> dict;


    void Awake()
    {
        InitializeSingleton();
        LoadSoundsToDict();
    }

    private void InitializeSingleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void LoadSoundsToDict()
    {
        sounds = Resources.LoadAll<AudioClip>("Sounds");
        dict = new Dictionary<string, AudioClip>();

        foreach (var sound in sounds)
        {
            bool addedToDict = dict.TryAdd(sound.name, sound);

            if (!addedToDict)
            {
                Debug.LogWarning("Sound not added" + sound.name);
            }
        }
    }

    public void PlaySound(string clipName, float volume, bool loop, Transform soundTransform)
    {
        if (string.IsNullOrEmpty(clipName)) { return; }

        if (dict.TryGetValue(clipName, out AudioClip sound))
        {
            EazySoundManager.PlaySound(sound, volume, loop, soundTransform);
        }
        else { Debug.LogWarning("Sound not found: " + clipName); }
    }

    public void PlayMusic(string clipName, float volume, bool loop, bool persist, float fadeIn, float fadeOut)
    {
        if (string.IsNullOrEmpty(clipName)) { return; }
        if (dict.TryGetValue(clipName, out AudioClip sound))
        {
            EazySoundManager.PlayMusic(sound, volume, loop, persist, fadeIn, fadeOut);
        }
        else { Debug.LogWarning("Music not found: " + clipName); }
    }
}