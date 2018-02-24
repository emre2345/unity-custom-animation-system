using System;
using System.Collections;
using System.Collections.Generic;
using DHCustomAnimations;
using DHCustomAnimations.Animatables;
using UnityEngine;

[RequireComponent(typeof(AnimationController))]
public class PositionAnimator : MonoBehaviour
{
	[SerializeField] private Vector3 start;
	[SerializeField] private Vector3 end;
	[SerializeField] private AnimationController controller;
	
	private ICanAnimate animatable;

	IEnumerator Start()
	{
		yield return new WaitForSeconds(1);
		
		animatable = new AnimatableVector3(start, end, ApplierFunc);
		controller.Play(new DHCustomAnimations.Animation(animatable));
	}

	private void ApplierFunc(Vector3 vector3)
	{
		transform.position = vector3;
	}
}
