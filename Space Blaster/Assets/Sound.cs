using UnityEngine.Audio;
using UnityEngine;

// represents a sound used within program

[System.Serializable]
public class Sound {

    public string name;
    public AudioClip clip;
    public bool loop;
    public AudioMixerGroup group;

    [HideInInspector]
    public AudioSource source;

    [Range(0f, 1f)]
    public float volume;

    [Range(0f, 1f)]
    public float pitch;


}
