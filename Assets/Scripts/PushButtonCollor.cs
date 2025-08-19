using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PushButtonCollor : MonoBehaviour
{
    [SerializeField] private float _changeColorSpeed = 10f;

    private Image _image;

    private WaitForSeconds _waitForSeconds = new WaitForSeconds(0.05f);

    private Color _originalColor;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        _originalColor = _image.color;
    }

    public IEnumerator ChangeColorCorootine()
    {
        MakeDarker();

        yield return _waitForSeconds;

        MakeBrighter();
    }

    public void ChangeColor()
    {
        StartCoroutine(ChangeColorCorootine());
    }

    private void MakeDarker()
    {
        _image.DOColor(Color.red, Time.deltaTime * _changeColorSpeed);
    }

    private void MakeBrighter()
    {
        _image.DOColor(_originalColor, Time.deltaTime * _changeColorSpeed);
    }
}
