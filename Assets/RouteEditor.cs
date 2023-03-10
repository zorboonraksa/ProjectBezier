#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(Route))]
public class RouteEditor : Editor
{
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        
        if(GUILayout.Button("Create Route"))
        {
            ((Route)target).SetRoute();
        }
    }
}
#endif