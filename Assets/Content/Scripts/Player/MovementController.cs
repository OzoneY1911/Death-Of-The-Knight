using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class MovementController : SingletonMono<MovementController>
{
    private Rigidbody2D _rb;
    private InputManager _inputManager;
    private Animator _animator;

    [SerializeField] private float _walkSpeed = 2f;

    private Vector2 _movement;

    protected override void Awake()
    {
        base.Awake();

        _inputManager = GetComponent<InputManager>();
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _movement = _inputManager.GetPlayerWalk();
    }

    private void FixedUpdate()
    {
        if (_inputManager.GetPlayerWalk() != Vector2.zero)
        {
            _rb.velocity = (_inputManager.GetPlayerWalk()).normalized * _walkSpeed;
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }
    }

    private void Update()
    {
        _movement.x = _inputManager.GetPlayerWalk().x;
        _movement.y = _inputManager.GetPlayerWalk().y;
        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
    }
}
