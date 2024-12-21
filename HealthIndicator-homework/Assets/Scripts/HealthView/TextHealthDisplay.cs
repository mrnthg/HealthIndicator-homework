using UnityEngine;
using UnityEngine.UI;

public class TextHealthDisplay : MonoBehaviour
{
    [SerializeField] private Text _healthText;
    [SerializeField] private HealthSystem _healthSystem;

    private string _displayHealthTemplate = "/100";

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
        _healthText.text = _healthSystem.Health + _displayHealthTemplate;
    }
}
