using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.VFX.Operator
{
    [VFXInfo(category = "Noise")]
    class SimplexNoise2D : NoiseBase
    {
        public class InputProperties
        {
            [Tooltip("The coordinate in the noise field to take the sample from.")]
            public Vector2 coordinate = Vector2.zero;
        }

        override public string name { get { return "Simplex Noise (2D)"; } }

        protected override sealed VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return new[] { new VFXExpressionSimplexNoise2D(inputExpression[0], new VFXExpressionCombine(inputExpression[1], inputExpression[2], inputExpression[4]), inputExpression[3]) };
        }
    }
}
