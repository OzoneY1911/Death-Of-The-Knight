using UnityEngine;

public class Human : MonoBehaviour
{
    private Animator _animator;

    private bool _canDie;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_canDie && !AttackController._canAttack)
        {
            _animator.SetTrigger("Die");
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _canDie = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canDie = false;
    }
}