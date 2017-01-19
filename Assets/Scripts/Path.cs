using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Path : MonoBehaviour 
{
	[Header ("Editor")]
	public bool launchPath;
	public bool launchPathBackwards;
	
	[Header ("Ball")]
	public Transform currentTarget;
	public string ballTag;
	public float ballVelocity;

	[Header ("Path Points")]
	public Vector3[] pathPoints = new Vector3[0];

	[Header ("Path ")]
	[Range (0, 1f)]
	public float pathPercentage;

	[Header ("Path Settings")]
	public int pathResolution = 10;
	public Color pathColor = Color.green;

	private PathType pathType = PathType.CatmullRom;
	private PathMode pathMode = PathMode.Full3D;

	private Tween pathTween;

	// Use this for initialization
	void Start () 
	{
		SetupPath ();

		//LaunchPath ();
	}

	void SetupPath ()
	{
		pathPoints = new Vector3[transform.childCount];

		pathPoints [0] = transform.GetChild (0).position;

		for(int i = 1; i < transform.childCount - 1; i++)
			pathPoints [i] = transform.GetChild (i).position;

		pathPoints [pathPoints.Length - 1] = transform.GetChild (transform.childCount - 1).position;
	}

	void LaunchPath (bool backwards = false)
	{
		if (currentTarget == null)
			currentTarget = GameObject.FindGameObjectWithTag (ballTag).transform;

		if(!backwards)
			pathTween = currentTarget.DOLocalPath (pathPoints, ballVelocity, pathType, pathMode, pathResolution, pathColor).SetSpeedBased ().SetEase (Ease.Linear).OnUpdate (PathPercentage);
		else
		{
			pathTween = currentTarget.DOLocalPath (pathPoints, ballVelocity, pathType, pathMode, pathResolution, pathColor).SetSpeedBased ().SetEase (Ease.Linear).OnUpdate (PathPercentage);
			pathTween.PlayBackwards ();
		}
	}

	void GetPathEnd ()
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		if(launchPath)
		{
			launchPath = false;

			if (!pathTween.IsPlaying ())
				LaunchPath ();
			else
				pathTween.PlayForward ();
		}

		if(launchPathBackwards)
		{
			launchPathBackwards = false;

			if (pathTween.IsPlaying ())
				pathTween.PlayBackwards ();
		}
	}

	void PathPercentage ()
	{
		pathPercentage = pathTween.ElapsedPercentage ();
	}

	void OnTriggerEnter (Collider collider)
	{
		if(collider.tag == ballTag)
		{
			currentTarget = collider.transform;
			ballVelocity = currentTarget.GetComponent<Rigidbody> ().velocity.magnitude;

			LaunchPath ();
		}
	}
}
