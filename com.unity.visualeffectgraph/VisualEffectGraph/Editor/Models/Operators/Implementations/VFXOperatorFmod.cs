using System;

namespace UnityEditor.VFX
{
    [VFXInfo]
    class VFXOperatorFmod : VFXOperatorFloatUnified
    {
        public class InputProperties
        {
            public FloatN right = new FloatN(new[] { 1.0f });
            public FloatN left = new FloatN(new[] { 1.0f });
        }

        override public string name { get { return "Fmod"; } }

        protected override VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            var div = new VFXExpressionDivide(inputExpression[0], inputExpression[1]);
            return new[] { new VFXExpressionMul(VFXOperatorUtility.Frac(div), inputExpression[1]) };
        }
    }
}
