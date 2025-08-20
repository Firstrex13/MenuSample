using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    [SerializeField] private Toggle _toggle;
    [SerializeField] private Slider _slider;

    public void ToggleMusic()
    {
        if (_toggle.isOn)
        {
            _mixerGroup.audioMixer.SetFloat("Music", -80);
        }
        else
        {
            _mixerGroup.audioMixer.SetFloat("Music", 0);
        }
    }

    public void ChangeVolume()
    {
        _mixerGroup.audioMixer.SetFloat("Music", Mathf.Lerp(-80, 0, _slider.value));
    }
}
