using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    public void Play()
    {
        _sound.Play();
    }
}
