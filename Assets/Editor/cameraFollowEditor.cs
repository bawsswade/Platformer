using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof (camera_follow))]
public class cameraFollowEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();

		camera_follow cf = (camera_follow)target;

		if(GUILayout.Button("Set Min"))
		{
			cf.SetMinPos();
		}

		if(GUILayout.Button("Set Max"))
		{
			cf.SetMaxPos();
		}
	}
}
