using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CameraFollow))]
public class CameraFollowEditor : Editor
{
    public override void OnInspectorGUI()
    {
        CameraFollow cameraFollow = (CameraFollow) target;

        if (DrawDefaultInspector())
        {
            if (cameraFollow.autoUpdate)
            {
                cameraFollow.UpdateCameraOffset();
            }
        }
        
        if (GUILayout.Button("Update"))
        {
            cameraFollow.UpdateCameraOffset();
        }
    }
}
