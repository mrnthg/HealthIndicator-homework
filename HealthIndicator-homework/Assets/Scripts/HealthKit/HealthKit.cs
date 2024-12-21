using UnityEngine;
using UnityEngine.UI;

public class HealthKit : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField, Range(1f, 100f)] private float _healthPoint = 20;
    [SerializeField] private HealthSystem _healthSystem;

    private void OnEnable()
    {
        _button.onClick.AddListener(TakeHealthKit);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(TakeHealthKit);
    }

    private void TakeHealthKit()
    {
        _healthSystem.AddHealthPoint(_healthPoint);
    }
}
