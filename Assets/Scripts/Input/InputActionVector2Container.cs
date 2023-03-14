using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Processors;

namespace Dynamic.Input
{
    [CreateAssetMenu(fileName = "New Input Action Container",menuName = "Settings/Input Action Container")]
    public class InputActionVector2Container : ScriptableObject
    {
        public InputActionReference inputAction;

        public void SetScale(float value)
        {
            inputAction.action.ApplyParameterOverride((ScaleVector2Processor sp) => sp.x, value);
            inputAction.action.ApplyParameterOverride((ScaleVector2Processor sp) => sp.y, value);
        }

        public void InvertX(bool value) => inputAction.action.ApplyParameterOverride((InvertVector2Processor ip) => ip.invertX, value);

        public void InvertY(bool value) => inputAction.action.ApplyParameterOverride((InvertVector2Processor ip) => ip.invertY, value);
    }
}