using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : SingletonMono<PlayerHealth>
{
    [SerializeField] private Slider _healthBar;

    [SerializeField] private int _health;

    protected override void Awake()
    {
        base.Awake();

        _health = 100;
    }

    private void Update()
    {
        _healthBar.value = _health / 100f;
    }

    private void TakeDamage()
    {
        _health -= 10;
    }
}