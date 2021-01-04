// Original Script
using UnityEngine;
using Vectrosity;
using System.Collections;
using System.Collections.Generic;

public class SplineFollow3D : MonoBehaviour {

	public int segments = 250;
	public bool doLoop = true;
	public Transform cube;
	public float speed = .05f;
	
	IEnumerator Start () {
		var splinePoints = new List<Vector3>();
		var i = 1;
		var obj = GameObject.Find ("Sphere"+(i++));
		while (obj != null) {
			splinePoints.Add (obj.transform.position);
			obj = GameObject.Find ("Sphere"+(i++));
		}
	
		var line = new VectorLine("Spline", new List<Vector3>(segments+1), 2.0f, LineType.Continuous);
		line.MakeSpline (splinePoints.ToArray(), segments, doLoop);
		line.Draw3D();
		
		// Make the cube "ride" the spline at a constant speed
		do {
			for (var dist = 0.0f; dist < 1.0f; dist += Time.deltaTime*speed) {
				cube.position = line.GetPoint3D01 (dist);
				yield return null;
			}
		} while (doLoop);
	}
}