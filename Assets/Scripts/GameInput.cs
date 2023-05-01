//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/GameInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Arcanoid
{
    public partial class @GameInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""FirstPlayerGameplay"",
            ""id"": ""38a7e4a4-f25a-4255-8f5a-258591933ebf"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""956dd66e-4141-48c1-aad6-8ab9d028841e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ReleaseBall"",
                    ""type"": ""Button"",
                    ""id"": ""015b19a0-9688-4bbc-916a-d2c8c10d228d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""20af4532-f520-4a1a-b7a4-349a422ae917"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71ef151d-f339-4461-a672-47e812de37e1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""45ef5edb-ed78-4ce3-941f-31548613129a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""374e0715-a203-436c-b0b8-e632a5b70781"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d5b0e4a9-3ca0-411c-9b54-dde76ed25a87"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ba24fcac-f367-42e4-9d64-04d6987ab2e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SecondPlayerGameplay"",
            ""id"": ""0ed2f3e3-5fca-4b11-8336-bffbe7646755"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""28f44e5a-9592-4dd0-9e57-40e4b8e5bdcb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""0b4e7f8f-dedb-4126-b5fd-98eb4fc5a289"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d83b9af5-b01b-4df8-89e6-3817db4a23d2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b5c1108c-6290-4d73-9e19-42c529fac904"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8a7a059e-6633-4fc5-b066-1c6519bffa75"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""63a6136d-bc85-43dd-99d1-7bec9e9a5180"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // FirstPlayerGameplay
            m_FirstPlayerGameplay = asset.FindActionMap("FirstPlayerGameplay", throwIfNotFound: true);
            m_FirstPlayerGameplay_Move = m_FirstPlayerGameplay.FindAction("Move", throwIfNotFound: true);
            m_FirstPlayerGameplay_ReleaseBall = m_FirstPlayerGameplay.FindAction("ReleaseBall", throwIfNotFound: true);
            // SecondPlayerGameplay
            m_SecondPlayerGameplay = asset.FindActionMap("SecondPlayerGameplay", throwIfNotFound: true);
            m_SecondPlayerGameplay_Move = m_SecondPlayerGameplay.FindAction("Move", throwIfNotFound: true);
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
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // FirstPlayerGameplay
        private readonly InputActionMap m_FirstPlayerGameplay;
        private IFirstPlayerGameplayActions m_FirstPlayerGameplayActionsCallbackInterface;
        private readonly InputAction m_FirstPlayerGameplay_Move;
        private readonly InputAction m_FirstPlayerGameplay_ReleaseBall;
        public struct FirstPlayerGameplayActions
        {
            private @GameInput m_Wrapper;
            public FirstPlayerGameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_FirstPlayerGameplay_Move;
            public InputAction @ReleaseBall => m_Wrapper.m_FirstPlayerGameplay_ReleaseBall;
            public InputActionMap Get() { return m_Wrapper.m_FirstPlayerGameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(FirstPlayerGameplayActions set) { return set.Get(); }
            public void SetCallbacks(IFirstPlayerGameplayActions instance)
            {
                if (m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnMove;
                    @ReleaseBall.started -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnReleaseBall;
                    @ReleaseBall.performed -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnReleaseBall;
                    @ReleaseBall.canceled -= m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface.OnReleaseBall;
                }
                m_Wrapper.m_FirstPlayerGameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @ReleaseBall.started += instance.OnReleaseBall;
                    @ReleaseBall.performed += instance.OnReleaseBall;
                    @ReleaseBall.canceled += instance.OnReleaseBall;
                }
            }
        }
        public FirstPlayerGameplayActions @FirstPlayerGameplay => new FirstPlayerGameplayActions(this);

        // SecondPlayerGameplay
        private readonly InputActionMap m_SecondPlayerGameplay;
        private ISecondPlayerGameplayActions m_SecondPlayerGameplayActionsCallbackInterface;
        private readonly InputAction m_SecondPlayerGameplay_Move;
        public struct SecondPlayerGameplayActions
        {
            private @GameInput m_Wrapper;
            public SecondPlayerGameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_SecondPlayerGameplay_Move;
            public InputActionMap Get() { return m_Wrapper.m_SecondPlayerGameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SecondPlayerGameplayActions set) { return set.Get(); }
            public void SetCallbacks(ISecondPlayerGameplayActions instance)
            {
                if (m_Wrapper.m_SecondPlayerGameplayActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_SecondPlayerGameplayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_SecondPlayerGameplayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_SecondPlayerGameplayActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_SecondPlayerGameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public SecondPlayerGameplayActions @SecondPlayerGameplay => new SecondPlayerGameplayActions(this);
        public interface IFirstPlayerGameplayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnReleaseBall(InputAction.CallbackContext context);
        }
        public interface ISecondPlayerGameplayActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
