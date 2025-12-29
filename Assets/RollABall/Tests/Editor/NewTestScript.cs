using NUnit.Framework;
using UnityEngine.InputSystem;

namespace RollABall.Tests.Editor
{
    public class NewTestScript : InputTestFixture
    {
        [Test]
        public void NewTestScriptSimplePasses()
        {
            var gamepad = InputSystem.AddDevice<Gamepad>();
            Press(button: gamepad.buttonSouth);
        }
    }
}
