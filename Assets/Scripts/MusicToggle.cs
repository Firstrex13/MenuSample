using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    [SerializeField] private Volume _volume;
    [SerializeField] private AudioMixerGroup _mixerGroup;

    private Toggle _toggle;

    private float _minValue = 0;
    private float _maxValue = 1;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleMusic);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleMusic);
    }

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    public void ToggleMusic(bool enabled)
    {

        if (enabled)
        {
            _volume.SetValue(_minValue, _mixerGroup);
        }
        else
        {
            _volume.SetValue(_maxValue, _mixerGroup);
        }
    }
}
