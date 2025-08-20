using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class EffectsVolume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Slider _volumeSlider;

    public void ChangeVolume()
    {
        _mixerGroup.audioMixer.SetFloat("EffectsVolume", Mathf.Lerp(-80, 0, _volumeSlider.value));
    }
}
