using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Path : MonoBehaviour 
{
	[Header ("Ball")]
	public string ballTag;
	public float ballVelocityFactor = 1;

	[Header ("Path Points")]
	public Vector3[] pathPoints = new Vector3[0];

	[Header ("Path Settings")]
	public Ease pathEase = Ease.Linear;
	public int pathResolution = 10;
	public Color pathColor = Color.green;

	private PathType pathType = PathType.CatmullRom;
	private PathMode pathMode = PathMode.Full3D;

	// Use this for initialization
	void Start () 
	{
		SetupPath ();
	}

	void SetupPath ()
	{
		pathPoints = new Vector3[transform.childCount];

		pathPoints [0] = transform.GetChild (0).position;

		for(int i = 1; i < transform.childCount - 1; i++)
			pathPoints [i] = transform.GetChild (i).position;

		pathPoints [pathPoints.Length - 1] = transform.GetChild (transform.childCount - 1).position;
	}

	void LaunchPath (Transform target, float velocity, bool backwards = false)
	{
		target.DOLocalPath (pathPoints, velocity * ballVelocityFactor, pathType, pathMode, pathResolution, pathColor).SetSpeedBased ().SetEase (pathEase).OnComplete (()=> PathComplete(target));
	}

	void PathComplete (Transform target) 
	{
		target.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}

	void OnTriggerEnter (Collider collider)
	{
		if(collider.tag == ballTag)
		{
			float velocity = collider.transform.GetComponent<Rigidbody> ().velocity.magnitude;

			LaunchPath (collider.transform, velocity);
		}
	}
}
