// GENERATED AUTOMATICALLY FROM 'Assets/SCRIPTS/CONTROLLER/Cube_Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Cube_Control : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Cube_Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Cube_Control"",
    ""maps"": [
        {
            ""name"": ""YES_CUBE"",
            ""id"": ""3e97192c-0665-4983-a5ee-5f78885c0e3c"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""Value"",
                    ""id"": ""31b6698d-e901-43ac-8558-ef7349390d4a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b783a9bd-cb6c-4e0d-b03f-9103aeaf2a70"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c790dc0c-0e8e-4a16-9368-d2a256777a7a"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // YES_CUBE
        m_YES_CUBE = asset.FindActionMap("YES_CUBE", throwIfNotFound: true);
        m_YES_CUBE_MOVE = m_YES_CUBE.FindAction("MOVE", throwIfNotFound: true);
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

    // YES_CUBE
    private readonly InputActionMap m_YES_CUBE;
    private IYES_CUBEActions m_YES_CUBEActionsCallbackInterface;
    private readonly InputAction m_YES_CUBE_MOVE;
    public struct YES_CUBEActions
    {
        private @Cube_Control m_Wrapper;
        public YES_CUBEActions(@Cube_Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_YES_CUBE_MOVE;
        public InputActionMap Get() { return m_Wrapper.m_YES_CUBE; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(YES_CUBEActions set) { return set.Get(); }
        public void SetCallbacks(IYES_CUBEActions instance)
        {
            if (m_Wrapper.m_YES_CUBEActionsCallbackInterface != null)
            {
                @MOVE.started -= m_Wrapper.m_YES_CUBEActionsCallbackInterface.OnMOVE;
                @MOVE.performed -= m_Wrapper.m_YES_CUBEActionsCallbackInterface.OnMOVE;
                @MOVE.canceled -= m_Wrapper.m_YES_CUBEActionsCallbackInterface.OnMOVE;
            }
            m_Wrapper.m_YES_CUBEActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MOVE.started += instance.OnMOVE;
                @MOVE.performed += instance.OnMOVE;
                @MOVE.canceled += instance.OnMOVE;
            }
        }
    }
    public YES_CUBEActions @YES_CUBE => new YES_CUBEActions(this);
    public interface IYES_CUBEActions
    {
        void OnMOVE(InputAction.CallbackContext context);
    }
}
