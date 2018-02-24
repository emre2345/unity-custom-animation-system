using System;
using UnityEngine;

namespace DHCustomAnimations.Animatables
{
    public class AnimatableFloat : Animatable<float>
    {
        public AnimatableFloat(float start, float end, Action<float> applierFunc) : base(start, end, applierFunc)
        {
        }

        public override void Animate(float dt)
        {
            applierFunc(Mathf.Lerp(start, end, dt));
        }
    }
}