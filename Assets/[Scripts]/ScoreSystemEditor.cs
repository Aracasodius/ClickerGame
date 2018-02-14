using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScoreSystem))]
public class ScoreSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        ScoreSystem targetScript = (ScoreSystem)target;

        if (GUILayout.Button("Reset Score")) { targetScript.ResetScore(); }
        if (GUILayout.Button("Reset ALL")) { targetScript.ResetAll(); }
    }
}
