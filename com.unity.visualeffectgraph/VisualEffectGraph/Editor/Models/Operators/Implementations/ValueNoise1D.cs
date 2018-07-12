using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.VFX.Operator
{
    [VFXInfo(category = "Noise")]
    class ValueNoise1D : NoiseBase
    {
        public class InputProperties
        {
            [Tooltip("The coordinate in the noise field to take the sample from.")]
            public float coordinate = 0.0f;
        }

        override public string name { get { return "Value Noise (1D)"; } }

        protected override sealed VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return new[] { new VFXExpressionValueNoise1D(inputExpression[0], new VFXExpressionCombine(inputExpression[1], inputExpression[2], inputExpression[4]), inputExpression[3]) };
        }
    }
}
