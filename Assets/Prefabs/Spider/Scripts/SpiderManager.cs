using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SpiderManager : MonoBehaviour
{
	
	[SerializeField]
	private Rigidbody rPointerParent;
	[SerializeField]
	private bool DebugMode = false;

	[SerializeField]
	private UnityEvent Bonus1;
	[SerializeField]
	private UnityEvent Bonus2;
	[SerializeField]
	private UnityEvent Bonus3;
	[SerializeField]
	private UnityEvent Bonus4;
	[SerializeField]
	private UnityEvent Bonus5;
	[SerializeField]
	private UnityEvent Bonus6;
	[SerializeField]
	private UnityEvent Bonus7;
	[SerializeField]
	private UnityEvent Bonus8;



	private float Speed;
	private bool Stopped = true;
	private int DebugResult;


	void Start ()
	{
		rPointerParent.maxAngularVelocity = 1000000000000000;
		if (DebugMode) {
			LaunchPointer ();
		}
	}

	void Update ()
	{
		if (rPointerParent.angularVelocity.z > -0.2f && Stopped == false) {
			Stopped = true;
			rPointerParent.angularVelocity = Vector3.zero;
			Result ();
		}
			
	}

	public void LaunchPointer ()
	{
		Speed = Random.Range (-200, -800);
		rPointerParent.AddRelativeTorque (new Vector3 (Speed, 0, 0));
		Stopped = false;
	}



	private void Result ()
	{

		if (rPointerParent.gameObject.transform.eulerAngles.x > 45 && rPointerParent.gameObject.transform.eulerAngles.x < 90 && rPointerParent.gameObject.transform.eulerAngles.y > 200) {
			Bonus1.Invoke ();
			DebugResult = 1;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 0 && rPointerParent.gameObject.transform.eulerAngles.x < 45 && rPointerParent.gameObject.transform.eulerAngles.y > 200) {
			Bonus2.Invoke ();
			DebugResult = 2;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 315 && rPointerParent.gameObject.transform.eulerAngles.x < 360 && rPointerParent.gameObject.transform.eulerAngles.y > 200) {
			Bonus3.Invoke ();
			DebugResult = 3;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 275 && rPointerParent.gameObject.transform.eulerAngles.x < 315 && rPointerParent.gameObject.transform.eulerAngles.y > 200) {
			Bonus4.Invoke ();
			DebugResult = 4;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 270 && rPointerParent.gameObject.transform.eulerAngles.x < 315 && rPointerParent.gameObject.transform.eulerAngles.y < 200) {
			Bonus5.Invoke ();
			DebugResult = 5;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 315 && rPointerParent.gameObject.transform.eulerAngles.x < 360 && rPointerParent.gameObject.transform.eulerAngles.y < 200) {
			Bonus6.Invoke ();
			DebugResult = 6;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 0 && rPointerParent.gameObject.transform.eulerAngles.x < 45 && rPointerParent.gameObject.transform.eulerAngles.y < 200) {
			Bonus7.Invoke ();
			DebugResult = 7;
		}
		if (rPointerParent.gameObject.transform.eulerAngles.x > 45 && rPointerParent.gameObject.transform.eulerAngles.x < 90 && rPointerParent.gameObject.transform.eulerAngles.y < 200) {
			Bonus8.Invoke ();
			DebugResult = 8;
		}


		if (DebugMode) {
			LaunchPointer ();
			Debug.Log (DebugResult);
		}
	}
		
}
