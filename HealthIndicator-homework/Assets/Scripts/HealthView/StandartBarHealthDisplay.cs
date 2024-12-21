using UnityEngine;
using UnityEngine.UI;

public class StandartBarHealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private HealthSystem _healthSystem;

    private float _correctionNumber = 100;

    private void Start()
    {
        SetHealth();
    }

    private void Update()
    {
        SetHealth();
    }

    private void SetHealth()
    {
        _healthSlider.value = _healthSystem.Health / _correctionNumber;
    }
}
