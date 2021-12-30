// GENERATED AUTOMATICALLY FROM 'Assets/PlayerActions.inputactions'

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
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Boat"",
            ""id"": ""405e82b1-a040-4907-98d0-c51674f3c58e"",
            ""actions"": [
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""bbd8d495-e372-4f00-87cc-d48fa451e7ee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""c71ea77c-28d1-4d42-8f47-5407a539a981"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reel"",
                    ""type"": ""Value"",
                    ""id"": ""a15dc563-3eb5-4a9a-abb2-5628aaad3cb9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05b9ff0f-b4a6-4508-bfdd-de945a96afdb"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard A/D"",
                    ""id"": ""5c481df0-07a4-4bda-9d18-1ba83a6e7be2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""32b4f116-3ccc-41fd-a4a5-26ddb49cde42"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b18f5736-5270-4106-9c96-6280caa887ae"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Q/E"",
                    ""id"": ""6375cbe7-4228-4de8-aac4-5a703f7c0aba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""10da43bd-4542-4a4e-8232-fa109d261e77"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8452a481-f351-4539-8bbe-0ab1969ea4f8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Shoulder Buttons"",
                    ""id"": ""e5cc8a12-2ada-4197-89b2-a44ae9aeb050"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0d6b0a57-8d6a-4135-9f09-6a47daaefb12"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b39617bd-24aa-4ce8-aab1-8f0d3f3f45d8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9718f8d0-99a6-4e31-836d-343480bbf076"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard S/W"",
                    ""id"": ""cd3089a4-0432-4bd3-87cb-bccf39f5342c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""135762f7-4fa8-41bf-b8db-42a50fb70c8c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fb2fe90d-d786-46a9-9413-ff02840a9b9f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Character"",
            ""id"": ""8eb16fcd-6782-443f-a128-32fca48eaa4d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3f57e1df-5301-4eac-87c1-b3bbaa8f36f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""918ea663-054e-4297-a538-131ddeb2c564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Glide"",
                    ""type"": ""PassThrough"",
                    ""id"": ""04c32b65-dfc5-4550-8789-8e74bf557716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3cf9c01-e022-408e-8e62-15b5a887417d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0157ab3a-8a46-4d4f-8bf8-a5e7ece3ebfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""11afffa7-695b-407e-9af3-584e948e73ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aac0294c-8625-4f08-af83-f996c4bc575c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Flashlight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f99cc6e-ebf6-411a-b8e0-4b20674206ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf4e92bc-442d-4a1a-ba1c-33ecb5bb7a74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ecd76d91-28c2-41a4-b8d1-0aa8c7f8fe28"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6dea8ebe-57b2-461c-bf29-5a812d4a851e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f1eb149b-09f7-4b13-bb50-a7d094f2c1e5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cacac4bd-9fee-4931-8ac3-95089f0fd456"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b2b6cdd7-c207-4eec-a37a-319b8e25897d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f6d9532d-b45a-48cf-973d-c1fc26ade278"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""fbabb462-6f45-4b42-966e-889961ce1f01"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2790f873-e6a3-4689-90f5-e2c242e7364f"",
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
                    ""id"": ""2404cf3e-4eb9-44b2-896b-6269c58c3e7a"",
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
                    ""id"": ""ee0fcbfc-a074-42f3-af5a-64fdb1eca7cb"",
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
                    ""id"": ""5e28fb18-d4f2-4e69-ae15-b24d940540cf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4cc6d9e9-685f-4ff9-901e-1ccba91cc361"",
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
                    ""id"": ""4a596803-7d5d-434b-9981-0bfcb25e668b"",
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
                    ""id"": ""a0e580b7-862d-48e6-b196-79f9acd7e676"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=30,y=20)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51d68927-386f-4c09-bbdb-4c784fb5c374"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a38ad9b-71e0-48f3-a862-5c9ec93c944b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc1f230f-aa1d-44d5-8fd3-a8f8b00e409a"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1beb76bd-fbdc-4732-a799-383207f20140"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84a5608f-6631-42f3-9e73-a6163a30d5ec"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e9effd-e2d6-4217-ae80-1ea982acc5ce"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58623265-79f8-4053-b997-9e709ec3a408"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27fae711-845e-4f41-92ba-50c906392039"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0fea58c-b1b4-43f1-b638-f29260833c9b"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe7e659-b631-44fa-a14d-a16efb3c73d0"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6aa817a-bae8-4de1-b1c6-03a46f69b48b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9cd36aa-0482-4636-97b9-3f2f01c75d5d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f715877-7d76-4a03-9f4b-2648c66a6b69"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reset"",
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
                },
                {
                    ""devicePath"": ""<Mouse>"",
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
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Boat
        m_Boat = asset.FindActionMap("Boat", throwIfNotFound: true);
        m_Boat_Turn = m_Boat.FindAction("Turn", throwIfNotFound: true);
        m_Boat_Pitch = m_Boat.FindAction("Pitch", throwIfNotFound: true);
        m_Boat_Reel = m_Boat.FindAction("Reel", throwIfNotFound: true);
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Glide = m_Character.FindAction("Glide", throwIfNotFound: true);
        m_Character_Look = m_Character.FindAction("Look", throwIfNotFound: true);
        m_Character_Fire = m_Character.FindAction("Fire", throwIfNotFound: true);
        m_Character_Aim = m_Character.FindAction("Aim", throwIfNotFound: true);
        m_Character_Run = m_Character.FindAction("Run", throwIfNotFound: true);
        m_Character_Flashlight = m_Character.FindAction("Flashlight", throwIfNotFound: true);
        m_Character_Reset = m_Character.FindAction("Reset", throwIfNotFound: true);
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

    // Boat
    private readonly InputActionMap m_Boat;
    private IBoatActions m_BoatActionsCallbackInterface;
    private readonly InputAction m_Boat_Turn;
    private readonly InputAction m_Boat_Pitch;
    private readonly InputAction m_Boat_Reel;
    public struct BoatActions
    {
        private @PlayerActions m_Wrapper;
        public BoatActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turn => m_Wrapper.m_Boat_Turn;
        public InputAction @Pitch => m_Wrapper.m_Boat_Pitch;
        public InputAction @Reel => m_Wrapper.m_Boat_Reel;
        public InputActionMap Get() { return m_Wrapper.m_Boat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoatActions set) { return set.Get(); }
        public void SetCallbacks(IBoatActions instance)
        {
            if (m_Wrapper.m_BoatActionsCallbackInterface != null)
            {
                @Turn.started -= m_Wrapper.m_BoatActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_BoatActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_BoatActionsCallbackInterface.OnTurn;
                @Pitch.started -= m_Wrapper.m_BoatActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_BoatActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_BoatActionsCallbackInterface.OnPitch;
                @Reel.started -= m_Wrapper.m_BoatActionsCallbackInterface.OnReel;
                @Reel.performed -= m_Wrapper.m_BoatActionsCallbackInterface.OnReel;
                @Reel.canceled -= m_Wrapper.m_BoatActionsCallbackInterface.OnReel;
            }
            m_Wrapper.m_BoatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Reel.started += instance.OnReel;
                @Reel.performed += instance.OnReel;
                @Reel.canceled += instance.OnReel;
            }
        }
    }
    public BoatActions @Boat => new BoatActions(this);

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Glide;
    private readonly InputAction m_Character_Look;
    private readonly InputAction m_Character_Fire;
    private readonly InputAction m_Character_Aim;
    private readonly InputAction m_Character_Run;
    private readonly InputAction m_Character_Flashlight;
    private readonly InputAction m_Character_Reset;
    public struct CharacterActions
    {
        private @PlayerActions m_Wrapper;
        public CharacterActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Glide => m_Wrapper.m_Character_Glide;
        public InputAction @Look => m_Wrapper.m_Character_Look;
        public InputAction @Fire => m_Wrapper.m_Character_Fire;
        public InputAction @Aim => m_Wrapper.m_Character_Aim;
        public InputAction @Run => m_Wrapper.m_Character_Run;
        public InputAction @Flashlight => m_Wrapper.m_Character_Flashlight;
        public InputAction @Reset => m_Wrapper.m_Character_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Glide.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnGlide;
                @Glide.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnGlide;
                @Glide.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnGlide;
                @Look.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFire;
                @Aim.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAim;
                @Run.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnRun;
                @Flashlight.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFlashlight;
                @Flashlight.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFlashlight;
                @Flashlight.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnFlashlight;
                @Reset.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Glide.started += instance.OnGlide;
                @Glide.performed += instance.OnGlide;
                @Glide.canceled += instance.OnGlide;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Flashlight.started += instance.OnFlashlight;
                @Flashlight.performed += instance.OnFlashlight;
                @Flashlight.canceled += instance.OnFlashlight;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
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
    public interface IBoatActions
    {
        void OnTurn(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnReel(InputAction.CallbackContext context);
    }
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGlide(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
}
