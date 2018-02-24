using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DHCustomAnimations
{
	[CreateAssetMenu(menuName = "DH/Animations/Create Curve", fileName = "Animation Curve", order = 0)]
	public class AnimationCurve : ScriptableObject
	{

		[SerializeField] private UnityEngine.AnimationCurve curve;

		public UnityEngine.AnimationCurve Curve
		{
			get { return curve; }
		}

		private void OnValidate()
		{
			if(curve.keys[0].time < 0 || curve.keys[curve.keys.Length - 1].time > 1)
				Debug.LogWarning(Errors.ANIMATION_CURVE_NOT_NORMALIZED);
		}
	}
}
