using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioMixerGroup _mixerGroup;

    public void Play()
    {
        _sound.Play();
    }
}
