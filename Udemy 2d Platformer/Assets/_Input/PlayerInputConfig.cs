// GENERATED AUTOMATICALLY FROM 'Assets/_Input/PlayerInputConfig.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputConfig : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputConfig()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputConfig"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""83d0bda8-4bbe-4d9e-af7d-f62260d55d76"",
            ""actions"": [
                {
                    ""name"": ""MoveAgnet"",
                    ""type"": ""Value"",
                    ""id"": ""b89920de-70bd-4f4a-ac5e-15286d6a9a5c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6bfa9ae3-b243-4ad2-98ae-f09d7b9ed743"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterMenu"",
                    ""type"": ""Button"",
                    ""id"": ""8be2d233-f1ee-47d9-94db-53f6d7a2df39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""a72acf1d-3314-4db4-b80b-d02e2552c80a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""059dfc49-0246-4555-ac93-bdff1431a530"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""56f91bb5-88c9-4aa3-a735-6e91730c8699"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3d71b557-0ce0-4dc7-81bd-32efa12f1d8b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""307871c8-1cc5-48cf-9b23-22db19065e51"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8250c97d-221b-48cd-85fd-bab9eb3d274f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1e90bab9-be7e-4ed2-b57b-0ea5fe3d1581"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveAgnet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c74db78d-055e-4255-b1b1-45a52e30dde8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0e7aaf0-bbc4-4053-8b15-3981322e14f6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfe9f8fa-e4a3-4be5-a6d1-68524fed91e8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c72ee9a-b643-470f-95c6-54862fadc370"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""080046b5-b384-4712-99cd-8e92cdcf2871"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""13aa01c0-e5e6-46f2-a051-e5cc05a6be21"",
            ""actions"": [
                {
                    ""name"": ""ExitMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4397b124-cf62-421c-9860-1d2b88a09b7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""befefe91-c8e0-4151-8bb0-5859037a6d76"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3b5abc1-f7c7-43e4-a44b-faf95e659267"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_MoveAgnet = m_PlayerMovement.FindAction("MoveAgnet", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_EnterMenu = m_PlayerMovement.FindAction("EnterMenu", throwIfNotFound: true);
        m_PlayerMovement_Attack = m_PlayerMovement.FindAction("Attack", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_ExitMenu = m_PauseMenu.FindAction("ExitMenu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_MoveAgnet;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_EnterMenu;
    private readonly InputAction m_PlayerMovement_Attack;
    public struct PlayerMovementActions
    {
        private @PlayerInputConfig m_Wrapper;
        public PlayerMovementActions(@PlayerInputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveAgnet => m_Wrapper.m_PlayerMovement_MoveAgnet;
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @EnterMenu => m_Wrapper.m_PlayerMovement_EnterMenu;
        public InputAction @Attack => m_Wrapper.m_PlayerMovement_Attack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @MoveAgnet.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMoveAgnet;
                @MoveAgnet.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMoveAgnet;
                @MoveAgnet.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMoveAgnet;
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @EnterMenu.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnEnterMenu;
                @EnterMenu.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnEnterMenu;
                @EnterMenu.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnEnterMenu;
                @Attack.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveAgnet.started += instance.OnMoveAgnet;
                @MoveAgnet.performed += instance.OnMoveAgnet;
                @MoveAgnet.canceled += instance.OnMoveAgnet;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @EnterMenu.started += instance.OnEnterMenu;
                @EnterMenu.performed += instance.OnEnterMenu;
                @EnterMenu.canceled += instance.OnEnterMenu;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private IPauseMenuActions m_PauseMenuActionsCallbackInterface;
    private readonly InputAction m_PauseMenu_ExitMenu;
    public struct PauseMenuActions
    {
        private @PlayerInputConfig m_Wrapper;
        public PauseMenuActions(@PlayerInputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitMenu => m_Wrapper.m_PauseMenu_ExitMenu;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterface != null)
            {
                @ExitMenu.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnExitMenu;
                @ExitMenu.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnExitMenu;
                @ExitMenu.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnExitMenu;
            }
            m_Wrapper.m_PauseMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitMenu.started += instance.OnExitMenu;
                @ExitMenu.performed += instance.OnExitMenu;
                @ExitMenu.canceled += instance.OnExitMenu;
            }
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnMoveAgnet(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEnterMenu(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnExitMenu(InputAction.CallbackContext context);
    }
}
