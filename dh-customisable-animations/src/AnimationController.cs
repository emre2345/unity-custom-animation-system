using System.Collections;
using DHCustomAnimations.Animatables;
using UnityEngine;
using Animation = DHCustomAnimations.Animation;

namespace DHCustomAnimations
{
    public class AnimationController : MonoBehaviour
    {
        [SerializeField] protected AnimationCurve curve;
        [SerializeField] protected float length;

        protected bool isPlaying;
        protected float normalizedTime;

        private Animation _animation;
        
        public float Length
        {
            get { return length; }
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
        }

        public float NormalizedTime
        {
            get { return normalizedTime; }
        }

        private void OnValidate()
        {
            if(curve == null)
                Debug.LogError(Errors.ANIMATION_CURVE_IS_NULL, gameObject);
        }

        public void Play(Animation animation)
        {
            this._animation = animation;
            StartCoroutine(PlayCoroutine());
        }

        IEnumerator PlayCoroutine()
        {
            float time = 0;
            isPlaying = true;
            
            while (time <= length)
            {
                normalizedTime = time / length;
                float value = curve.Curve.Evaluate(normalizedTime);
                
                _animation.AnimationOwner.Animate(value);
                
                time += Time.deltaTime;

                yield return null;
            }

            normalizedTime = 0;
            isPlaying = false;
        }
    }
}