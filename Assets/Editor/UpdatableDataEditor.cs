using System.Collections;
using UnityEngine;
using UnityEditor;

// Parameter 'true' specifies that we want the children of UpdatableData
// to also be affected by the editor script. 
[CustomEditor(typeof(UpdatableData), true)]
public class UpdatableDataEditor : Editor {
    
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        UpdatableData data = (UpdatableData)target;

        if (GUILayout.Button("Update")) {
            data.NotifyOfUpdatedValues();
            EditorUtility.SetDirty(target);
        }
    }
}
