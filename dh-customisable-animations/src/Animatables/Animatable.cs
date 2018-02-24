using System;
using UnityEngine;

namespace DHCustomAnimations.Animatables
{
    public class Animatable<T> : ICanAnimate
    {
        protected T start;
        protected T end;
        protected Action<T> applierFunc;

        public Animatable(T start, T end, Action<T> applierFunc)
        {
            if(applierFunc == null)
                Debug.LogError(Errors.APPLIER_FUNCTION_IS_NULL);
            
            this.start = start;
            this.end = end;
            this.applierFunc = applierFunc;
        }

        public virtual void Animate(float dt)
        {
        }
    }
}