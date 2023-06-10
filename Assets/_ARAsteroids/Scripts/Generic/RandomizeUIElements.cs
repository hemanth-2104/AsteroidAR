using UnityEngine;

public class RandomizeUIElements : MonoBehaviour
{
    [SerializeField] private RectTransform[] _elements;
    [SerializeField] private float _scaleMinValue = 0.1f;
    [SerializeField] private float _scaleMaxValue = 1f;
    [SerializeField] private float _positionThreshold = 5;

    void OnEnable()
    {
        foreach (var e in _elements)
        {
            float localScale = Random.Range(_scaleMinValue, _scaleMaxValue);
            e.localScale = new Vector3(localScale, localScale, 1);
            e.anchoredPosition = new Vector2(Random.Range(-_positionThreshold, _positionThreshold), Random.Range(-_positionThreshold, _positionThreshold));
        }
    }
}
