using UnityEngine;

public class InputManager : SingletonMono<InputManager>
{
    private PlayerControls _playerControls;

    #region Basic Methods

    protected override void Awake()
    {
        base.Awake();

        _playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    private void OnDestroy()
    {
        _playerControls.Dispose();
    }

    #endregion

    #region Movement Input

    public Vector2 GetPlayerWalk()
    {
        return _playerControls.Player.Walk.ReadValue<Vector2>();
    }

    #endregion

    public bool GetPlayerAttack()
    {
        return _playerControls.Armed.Attack.triggered;
    }
}
