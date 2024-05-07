using UnityEngine;
using System.Collections;

public class AttackController : SingletonMono<AttackController>
{
    private InputManager _inputManager;
    private Animator _animator;

    private float _attackTime = 0.5f;
    public static bool _canAttack = true;
    private Coroutine _attackCoroutine;

    protected override void Awake()
    {
        base.Awake();

        _inputManager = GetComponent<InputManager>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_inputManager.GetPlayerAttack() && _canAttack)
        {
            _animator.SetTrigger("Attack");

            _attackCoroutine = StartCoroutine(AttackCooldown());

            SoulCounter.Instance.Souls++;
        }
    }

    private IEnumerator AttackCooldown()
    {
        _canAttack = false;

        yield return new WaitForSeconds(_attackTime);

        _canAttack = true;
    }
}