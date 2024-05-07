using UnityEngine;
using TMPro;

public class SoulCounter : SingletonMono<SoulCounter>
{
    [SerializeField] private TextMeshProUGUI _soulCounter;

    public int Souls { get; set; }

    protected override void Awake()
    {
        base.Awake();
    }

    private void Update()
    {
        UpdateCounter();
    }

    private void UpdateCounter()
    {
        _soulCounter.text = $"Souls: {Souls}";
    }
}