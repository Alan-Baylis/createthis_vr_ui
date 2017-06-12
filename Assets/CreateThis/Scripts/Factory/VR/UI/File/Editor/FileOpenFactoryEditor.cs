﻿using UnityEngine;
using UnityEditor;

namespace CreateThis.Factory.VR.UI.File {
    [CustomEditor(typeof(FileOpenFactory))]
    [CanEditMultipleObjects]

    public class FileOpenFactoryEditor : BaseFactoryEditor {
        SerializedProperty parent;
        SerializedProperty panelProfile;
        SerializedProperty panelContainerProfile;
        SerializedProperty momentaryButtonProfile;
        SerializedProperty toggleButtonProfile;
        SerializedProperty folderPrefab;
        SerializedProperty kineticScrollerSpacing;
        SerializedProperty scrollerHeight;
        SerializedProperty searchPattern;

        protected override void OnEnable() {
            base.OnEnable();
            parent = serializedObject.FindProperty("parent");
            panelProfile = serializedObject.FindProperty("panelProfile");
            panelContainerProfile = serializedObject.FindProperty("panelContainerProfile");
            momentaryButtonProfile = serializedObject.FindProperty("momentaryButtonProfile");
            toggleButtonProfile = serializedObject.FindProperty("toggleButtonProfile");
            folderPrefab = serializedObject.FindProperty("folderPrefab");
            kineticScrollerSpacing = serializedObject.FindProperty("kineticScrollerSpacing");
            scrollerHeight = serializedObject.FindProperty("scrollerHeight");
            searchPattern = serializedObject.FindProperty("searchPattern");
            panelProfile = serializedObject.FindProperty("panelProfile");
        }

        protected override void BuildGenerateButton() {
            // Take out this if statement to set the value using setter when ever you change it in the inspector.
            // But then it gets called a couple of times when ever inspector updates
            // By having a button, you can control when the value goes through the setter and getter, your self.
            if (GUILayout.Button("Generate")) {
                if (target.GetType() == typeof(FileOpenFactory)) {
                    FileOpenFactory factory = (FileOpenFactory)target;
                    factory.Generate();
                }
            }
        }

        protected override void AdditionalProperties() {
            base.AdditionalProperties();
            EditorGUILayout.PropertyField(parent);
            EditorGUILayout.PropertyField(panelProfile);
            EditorGUILayout.PropertyField(panelContainerProfile);
            EditorGUILayout.PropertyField(momentaryButtonProfile);
            EditorGUILayout.PropertyField(toggleButtonProfile);
            EditorGUILayout.PropertyField(folderPrefab);
            EditorGUILayout.PropertyField(kineticScrollerSpacing);
            EditorGUILayout.PropertyField(scrollerHeight);
            EditorGUILayout.PropertyField(searchPattern);
        }
    }
}