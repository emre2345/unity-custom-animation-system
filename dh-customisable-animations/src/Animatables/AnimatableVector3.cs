using System;
using UnityEngine;

namespace DHCustomAnimations.Animatables
{
    public class AnimatableVector3 : Animatable<Vector3>
    {
        public AnimatableVector3(Vector3 start, Vector3 end, Action<Vector3> applierFunc) : base(start, end, applierFunc)
        {
        }

        public override void Animate(float dt)
        {
            applierFunc(Vector3.Lerp(start, end, dt));
        }
    }
}