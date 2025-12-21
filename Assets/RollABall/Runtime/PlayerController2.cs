#nullable enable

    using System;
    using UnityEngine;

    namespace RollABall
    {
        [ExcludeFromPreset]
        [ExcludeFromObjectFactory]
        [DisallowMultipleComponent]
        public sealed class PlayerController2 : MonoBehaviour
        {
            [SerializeField] public float m_Speed = 10;

            [NonSerialized] private PlayerControls? m_Controls;

            [NonSerialized] private Vector2 m_Move;

            private void Awake()
            {
                m_Controls                       =  new();
                m_Controls.Player.Move.performed += context => m_Move = context.ReadValue<Vector2>();
                m_Controls.Player.Move.canceled  += _ => m_Move       = Vector2.zero;
            }

            private void FixedUpdate()
            {
                var movement = new Vector3(
                    x: m_Move.x,
                    y: 0.0f,
                    z: m_Move.y
                ) * m_Speed * Time.fixedDeltaTime;
                transform.Translate(translation: movement, relativeTo: Space.World);
            }

            private void OnEnable()
            {
                m_Controls.Player.Enable();
            }

            private void OnDisable()
            {
                m_Controls.Player.Disable();
            }

            private void SendMessage(Vector2 coordinates)
            {
                Debug.LogFormat(format: "Thumb-stick coordinates = {0}", coordinates);
            }
        }
    }
