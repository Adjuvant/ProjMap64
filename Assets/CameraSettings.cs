using UnityEngine;
using System.Collections;

public class CameraSettings : MonoBehaviour {

	GameObject camera;
	public Matrix4x4 pm;
	public Quaternion rot;
	// Use this for initialization
	void Start () {
		//setCameraSettins (pm,rot);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.D))
			getCameraSettings();
	}

	void getCameraSettings () {
		Debug.LogError("Getting Projection Matrix");

		Matrix4x4 projectionMatrix;
		projectionMatrix = GetComponent<Camera>().projectionMatrix;
		Debug.LogError("Projection Matrix: " + projectionMatrix);
		Debug.LogError("Camera Position: " + transform.position);
		Debug.LogError("Camera Rotation: " + transform.eulerAngles);
	}

	void setCameraSettins (Matrix4x4 _projectionMatric, Quaternion _rot) {
		GetComponent<Camera>().projectionMatrix = _projectionMatric;
		//gameObject.transform.rotation = _rot;
	}
}
