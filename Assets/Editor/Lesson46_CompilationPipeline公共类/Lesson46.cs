using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

public class Lesson46 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson46/CompilationPipeline֪ʶ�㽲��")]
    private static void OpenLesson46()
    {
        Lesson46 win = EditorWindow.GetWindow<Lesson46>("CompilationPipeline֪ʶ�㽲��");
        win.Show();
    }

    private void OnEnable()
    {
        CompilationPipeline.assemblyCompilationFinished += CompilationPipeline_assemblyCompilationFinished;
        CompilationPipeline.compilationFinished += CompilationPipeline_compilationFinished;
    }

    private void CompilationPipeline_compilationFinished(object obj)
    {
        Debug.Log("���г��򼯱������"); 
    }

    private void CompilationPipeline_assemblyCompilationFinished(string arg1, CompilerMessage[] arg2)
    {
        Debug.Log("��������" + arg1);
    }

    private void OnDestroy()
    {
        CompilationPipeline.assemblyCompilationFinished -= CompilationPipeline_assemblyCompilationFinished;
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ CompilationPipeline��������������ʲô��
        //���� Unity �༭���е�һ�������࣬���ڴ�����������صĲ������¼���
        //����������˵��������õ�����������֪�����Ƿ�������
        //���綯̬���ɽű�ʱ��������Ҫ�ڱ�����������ʹ���µĽű� 
        #endregion

        #region ֪ʶ��� �����Զ���������ڽ���֪ʶ����

        #endregion

        #region ֪ʶ���� ��������
        //1.CompilationPipeline.assemblyCompilationFinished
        //  �����ռ䣺UnityEditor.Compilation;
        //  ��Ҫ���ã���һ�����򼯱���������������øûص�����
        //  ��������������ֱ���
        //  string arg1 : ������ɵĳ�����
        //  CompilerMessage[] arg2 : ������ɺ�����ı�����Ϣ���飬�������뾯��ʹ�����Ϣ

        //2.CompilationPipeline.compilationFinished
        //  �����ռ䣺UnityEditor.Compilation;
        //  ��Ҫ���ã������г��򼯱���������������øûص�����
        //  ����
        //  object obj: ActiveBuildStatus �����״̬����
        #endregion

        #region ֪ʶ���� ��������
        //https://docs.unity3d.com/ScriptReference/Compilation.CompilationPipeline.html
        #endregion
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
