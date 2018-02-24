using System;
using UnityEngine;

namespace DHCustomAnimations.Animatables
{
    public class AnimatableQuaternion : Animatable<Quaternion>
    {
        public AnimatableQuaternion(Quaternion start, Quaternion end, Action<Quaternion> applierFunc) : base(start, end, applierFunc)
        {
        }

        public override void Animate(float dt)
        {
            applierFunc(Quaternion.Lerp(start, end, dt));
        }
    }
}