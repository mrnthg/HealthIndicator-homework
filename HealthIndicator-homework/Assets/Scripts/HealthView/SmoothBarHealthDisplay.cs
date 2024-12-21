using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SmoothBarHealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private HealthSystem _healthSystem;
    [SerializeField, Min(1f)] private float _lerpSpeed = 3f;

    private void Update()
    {
        SetValueSlider(_lerpSpeed * Time.deltaTime);
    }

    private void SetValueSlider(float speed)
    {
        _healthSlider.value = Mathf.Lerp(_healthSlider.value, _healthSystem.Health / _healthSystem.MaxHealthPoint, speed);
    }
}
