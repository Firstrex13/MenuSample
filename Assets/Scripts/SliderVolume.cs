using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    [SerializeField] private Volume _volume;
    [SerializeField] private AudioMixerGroup _mixerGroup;

    private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void ChangeVolume(float value)
    {
        _volume.SetValue(value, _mixerGroup);
    }
}
