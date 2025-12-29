using UnityEngine;
using UnityEngine.InputSystem;

namespace RollABall
{
    public class InputDebuggerActionExample : MonoBehaviour
    {
        public InputAction exampleAction;

        private void OnEnable()
        {
            exampleAction.Enable();
        }
    }
}
