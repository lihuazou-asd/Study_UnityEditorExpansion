using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson12 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson12/EditorGUIUtilityѧϰ���")]
    private static void OpenLesson12()
    {
        Lesson12 win = EditorWindow.GetWindow<Lesson12>("EditorGUIUtilityѧϰ���");
        win.Show();
    }

    private void OnGUI()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ EditorGUIUtility��������������ʲô�ģ�
        // Utility��ʵ�õ���˼��EditorGUIUtility �� EditorGUI �е�һ��ʵ�ù�����
        // �ṩ��һЩ EditorGUI ��ص���������API
        // ����ֻ��Ҫѧϰ���е���Գ��õ�����

        // �ٷ��ĵ���https://docs.unity3d.com/ScriptReference/EditorGUIUtility.html
        #endregion

        #region ֪ʶ��� ׼������
        //����һ���Զ���༭������ ����֮��ѧϰEditorGUIUtility��ص�֪ʶ
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
