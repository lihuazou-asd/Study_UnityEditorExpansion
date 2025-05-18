using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson12 : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson12/EditorGUIUtility学习面板")]
    private static void OpenLesson12()
    {
        Lesson12 win = EditorWindow.GetWindow<Lesson12>("EditorGUIUtility学习面板");
        win.Show();
    }

    private void OnGUI()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 EditorGUIUtility公共类是用来做什么的？
        // Utility是实用的意思，EditorGUIUtility 是 EditorGUI 中的一个实用工具类
        // 提供了一些 EditorGUI 相关的其他辅助API
        // 我们只需要学习其中的相对常用的内容

        // 官方文档：https://docs.unity3d.com/ScriptReference/EditorGUIUtility.html
        #endregion

        #region 知识点二 准备工作
        //创建一个自定义编辑器窗口 用于之后学习EditorGUIUtility相关的知识
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
