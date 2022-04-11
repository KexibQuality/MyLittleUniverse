using UnityEditor;

namespace Entities.UnityEditor
{
    [CustomEditor(typeof(MonoEntity))]
    public sealed class MonoEntityEditor : Editor
    {
        private SerializedProperty elements;

        private void Awake()
        {
            this.elements = this.serializedObject.FindProperty(nameof(this.elements));
        }

        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();
            
            EditorGUILayout.Space(4.0f);
            EditorGUILayout.PropertyField(this.elements, includeChildren: true);
            
            this.serializedObject.ApplyModifiedProperties();
        }
    }
}