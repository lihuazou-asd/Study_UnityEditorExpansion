using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson26Window : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson26/��Scene��չ����")]
    private static void OpenLesson26()
    {
        Lesson26Window win = EditorWindow.GetWindow<Lesson26Window>();
        win.Show();
    }

    private void OnEnable()
    {
        SceneView.duringSceneGui += SceneUpdate;
    }

    private void OnDestroy()
    {
        SceneView.duringSceneGui -= SceneUpdate;
    }

    private void SceneUpdate(SceneView view)
    {
        Debug.Log("�Զ��崰����չScene�������");
    }
}
