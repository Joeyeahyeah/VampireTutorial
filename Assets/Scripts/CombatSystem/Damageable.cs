using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private UnityEvent takeDamage;

    private Color _defaultColor;

    public void TakeDamage(int damage)
    {
        health.DecreaseHealth(damage);
        spriteRenderer.DOColor(Color.red, 0.2f).SetLoops(2, LoopType.Yoyo).ChangeStartValue(_defaultColor);
        takeDamage.Invoke();
    }

    private void Awake()
    {
        _defaultColor = spriteRenderer.color;
    }
}