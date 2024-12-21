using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField, Range(1f, 100f)] private float _damage = 25;
    [SerializeField] private HealthSystem _healthSystem;

    private void OnEnable()
    {
        _button.onClick.AddListener(TakeDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(TakeDamage);
    }

    private void TakeDamage()
    {
        _healthSystem.SubtractHealthPoint(_damage);
    }
}
