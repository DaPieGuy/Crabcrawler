using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

    [System.Serializable]

public class Sound
{
    public string name;

    public AudioClip clip;
    [Range(0f, 2f)]
    public float volume;

    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    public AudioMixerGroup Output;

    [HideInInspector]
    public AudioSource source;

}
