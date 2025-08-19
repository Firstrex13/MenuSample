using UnityEngine;
using DG.Tweening;
using System.Collections;

public class PushButtonScale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 10f;

    private Transform _transform;

    private WaitForSeconds _waitForSeconds = new WaitForSeconds(0.05f);

    private void Awake()
    {
        _transform = transform;
    }

    public IEnumerator ChangeScaleCorootine()
    {
        DecreaseScale();

        yield return _waitForSeconds;

        EncreaseScale();
    }

    public void ChangeScale()
    {
        StartCoroutine(ChangeScaleCorootine());
    }

    private void DecreaseScale()
    {
        _transform.DOScale(new Vector3(5, 5, 5), Time.deltaTime * _scaleSpeed);
    }

    private void EncreaseScale()
    {
        _transform.DOScale(new Vector3(5.5f, 5.5f, 5.5f), Time.deltaTime * _scaleSpeed);
    }
}
