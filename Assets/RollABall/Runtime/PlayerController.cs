#nullable enable

using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RollABall
{
    [ExcludeFromPreset]
    [ExcludeFromObjectFactory]
    [DisallowMultipleComponent]
    [RequireComponent(requiredComponent: typeof(Rigidbody))]
    [RequireComponent(requiredComponent: typeof(PlayerInput))]
    public sealed class PlayerController : MonoBehaviour
    {
        [SerializeField] private float m_Speed = 1;

        private float m_MovementX;
        private float m_MovementY;

        [NonSerialized] private Rigidbody? m_Rigidbody;

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            var movement = new Vector3(
                x: m_MovementX,
                y: 0.0f,
                z: m_MovementY
            );
            m_Rigidbody!.AddForce(force: movement * m_Speed);
        }

        private void OnMove(InputValue movementValue)
        {
            var movementVector = movementValue.Get<Vector2>();

            m_MovementX = movementVector.x;
            m_MovementY = movementVector.y;
        }
    }
}
