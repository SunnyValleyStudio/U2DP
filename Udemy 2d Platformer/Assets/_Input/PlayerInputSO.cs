using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName ="PlayerInputSO", menuName ="PlayerHelpers/PlayerInput")]
public class PlayerInputSO : ScriptableObject, PlayerInputConfig.IPauseMenuActions,
    PlayerInputConfig.IPlayerMovementActions, IAgentInput
{
    PlayerInputConfig input;

    public event Action OnAttack;
    public event Action OnJumpPressed;
    public event Action OnJumpReleased;
    public event Action<Vector2> OnMovement;
    public event Action OnWeaponChange;

    public Vector2 MovementVector { get; private set; }

    public event Action OnMenu;

    private void OnEnable()
    {
        if (input == null)
        {
            input = new PlayerInputConfig();
            input.PlayerMovement.SetCallbacks(this);
            input.PauseMenu.SetCallbacks(this);

            input.PlayerMovement.Enable();
        }
    }

    private void OnDisable()
    {
        input = null;
        ResetEvents();
    }

    public void ResetEvents()
    {
        OnMenu = null;
        OnAttack = null;
        OnJumpPressed = null;
        OnJumpReleased = null;
        OnMovement = null;
        OnWeaponChange = null;
    }

    public void OnExitMenu(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            OnMenu?.Invoke();
            input.PauseMenu.Disable();
            input.PlayerMovement.Enable();
        }
    }

    public void OnMoveAgnet(InputAction.CallbackContext context)
    {
        MovementVector = context.ReadValue<Vector2>();
        OnMovement?.Invoke(MovementVector);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            OnJumpPressed?.Invoke();
        }
        else if(context.phase == InputActionPhase.Canceled)
        {
            OnJumpReleased?.Invoke();
        }
    }

    public void OnEnterMenu(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnMenu?.Invoke();
            input.PauseMenu.Enable();
            input.PlayerMovement.Disable();
        }
    }

    void PlayerInputConfig.IPlayerMovementActions.OnAttack(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            OnAttack?.Invoke();
        }
    }
}
