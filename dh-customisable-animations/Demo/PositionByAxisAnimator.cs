using System.Collections;
using System.Collections.Generic;
using DHCustomAnimations;
using DHCustomAnimations.Animatables;
using UnityEngine;

public class PositionByAxisAnimator : MonoBehaviour {

	[SerializeField] private Vector3 start;
	[SerializeField] private Vector3 end;
	[SerializeField] private AnimationController controllerX;
	[SerializeField] private AnimationController controllerY;
	[SerializeField] private AnimationController controllerZ;
	
	IEnumerator Start()
	{
		yield return new WaitForSeconds(1);
		
		ICanAnimate animatableX = new AnimatableFloat(start.x, end.x, ApplierFuncX);
		controllerX.Play(new DHCustomAnimations.Animation(animatableX));
		
		ICanAnimate animatableY = new AnimatableFloat(start.y, end.y, ApplierFuncY);
		controllerY.Play(new DHCustomAnimations.Animation(animatableY));
		
		ICanAnimate animatableZ = new AnimatableFloat(start.z, end.z, ApplierFuncZ);
		controllerZ.Play(new DHCustomAnimations.Animation(animatableZ));
	}

	private void ApplierFuncX(float f)
	{
		Vector3 pos = transform.position;
		pos.x = f;
		transform.position = pos;
	}
	
	private void ApplierFuncY(float f)
	{
		Vector3 pos = transform.position;
		pos.y = f;
		transform.position = pos;
	}
	
	private void ApplierFuncZ(float f)
	{
		Vector3 pos = transform.position;
		pos.z = f;
		transform.position = pos;
	}
}
