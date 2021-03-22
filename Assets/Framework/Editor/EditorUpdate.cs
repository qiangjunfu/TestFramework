using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class EditorUpdate
{
    [MenuItem("FQJ/EditorUpdate/Open Update", false, 1)]
    static void OpenUpdate()
    {
        EditorApplication.update += Update;
    }

    [MenuItem("FQJ/EditorUpdate/Close Update", false, 2)]
    static void CloseUpdate()
    {
        EditorApplication.update -= Update;
    }

    static void Update()
    {
        Debug.Log($"EditorUpdate -> Update()");
    }
}
