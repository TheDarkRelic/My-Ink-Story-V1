// GENERATED AUTOMATICALLY FROM 'Assets/Player Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Actions"",
    ""maps"": [
        {
            ""name"": ""TattooControls"",
            ""id"": ""eeada948-d259-4b15-8951-4adb46258901"",
            ""actions"": [
                {
                    ""name"": ""RunMachine"",
                    ""type"": ""Button"",
                    ""id"": ""480c22c0-e665-4fc4-99f6-dd5e6df1601d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e55f1548-c45a-4563-baf6-f7d15f4c0f00"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tray"",
                    ""type"": ""Button"",
                    ""id"": ""e6c79f63-bff8-4342-93e3-e7cdc8fe3910"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c6b214f-cea3-42f9-8044-603ea5fb7499"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""RunMachine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ce7be304-a101-48cd-a201-e2c195c85d27"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b6a8e09a-8b04-49af-a091-1f800cf873ce"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""72d83631-00c0-4cb2-b55d-a40e8c4aaf5f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2d0802fd-8b46-4528-bf84-656e427d7414"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""84048b5b-8f7d-49ae-a842-d785bb759631"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""987b7ea7-aa86-4e06-9497-7c777a40b7e4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Tray"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuControls"",
            ""id"": ""843c2d60-f017-4f06-a9eb-a36c2489bf22"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d66dcf1b-cff5-45c1-9edb-59d58b7e18d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6b9657cd-0b0d-4310-abb6-46f1ccdf1747"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // TattooControls
        m_TattooControls = asset.FindActionMap("TattooControls", throwIfNotFound: true);
        m_TattooControls_RunMachine = m_TattooControls.FindAction("RunMachine", throwIfNotFound: true);
        m_TattooControls_Movement = m_TattooControls.FindAction("Movement", throwIfNotFound: true);
        m_TattooControls_Tray = m_TattooControls.FindAction("Tray", throwIfNotFound: true);
        // MenuControls
        m_MenuControls = asset.FindActionMap("MenuControls", throwIfNotFound: true);
        m_MenuControls_Newaction = m_MenuControls.FindAction("New action", throwIfNotFound: true);
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

    // TattooControls
    private readonly InputActionMap m_TattooControls;
    private ITattooControlsActions m_TattooControlsActionsCallbackInterface;
    private readonly InputAction m_TattooControls_RunMachine;
    private readonly InputAction m_TattooControls_Movement;
    private readonly InputAction m_TattooControls_Tray;
    public struct TattooControlsActions
    {
        private @PlayerActions m_Wrapper;
        public TattooControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RunMachine => m_Wrapper.m_TattooControls_RunMachine;
        public InputAction @Movement => m_Wrapper.m_TattooControls_Movement;
        public InputAction @Tray => m_Wrapper.m_TattooControls_Tray;
        public InputActionMap Get() { return m_Wrapper.m_TattooControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TattooControlsActions set) { return set.Get(); }
        public void SetCallbacks(ITattooControlsActions instance)
        {
            if (m_Wrapper.m_TattooControlsActionsCallbackInterface != null)
            {
                @RunMachine.started -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnRunMachine;
                @RunMachine.performed -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnRunMachine;
                @RunMachine.canceled -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnRunMachine;
                @Movement.started -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnMovement;
                @Tray.started -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnTray;
                @Tray.performed -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnTray;
                @Tray.canceled -= m_Wrapper.m_TattooControlsActionsCallbackInterface.OnTray;
            }
            m_Wrapper.m_TattooControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RunMachine.started += instance.OnRunMachine;
                @RunMachine.performed += instance.OnRunMachine;
                @RunMachine.canceled += instance.OnRunMachine;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Tray.started += instance.OnTray;
                @Tray.performed += instance.OnTray;
                @Tray.canceled += instance.OnTray;
            }
        }
    }
    public TattooControlsActions @TattooControls => new TattooControlsActions(this);

    // MenuControls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_Newaction;
    public struct MenuControlsActions
    {
        private @PlayerActions m_Wrapper;
        public MenuControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MenuControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface ITattooControlsActions
    {
        void OnRunMachine(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnTray(InputAction.CallbackContext context);
    }
    public interface IMenuControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
