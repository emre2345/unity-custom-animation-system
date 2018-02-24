using DHCustomAnimations.Animatables;

namespace DHCustomAnimations
{
    public class Animation
    {
        private ICanAnimate animationOwner;

        public ICanAnimate AnimationOwner
        {
            get { return animationOwner; }
        }

        public Animation(ICanAnimate animationOwner)
        {
            this.animationOwner = animationOwner;
        }
    }
}