using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

public class Lesson46 : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson46/CompilationPipeline知识点讲解")]
    private static void OpenLesson46()
    {
        Lesson46 win = EditorWindow.GetWindow<Lesson46>("CompilationPipeline知识点讲解");
        win.Show();
    }

    private void OnEnable()
    {
        CompilationPipeline.assemblyCompilationFinished += CompilationPipeline_assemblyCompilationFinished;
        CompilationPipeline.compilationFinished += CompilationPipeline_compilationFinished;
    }

    private void CompilationPipeline_compilationFinished(object obj)
    {
        Debug.Log("所有程序集编译结束"); 
    }

    private void CompilationPipeline_assemblyCompilationFinished(string arg1, CompilerMessage[] arg2)
    {
        Debug.Log("程序集名：" + arg1);
    }

    private void OnDestroy()
    {
        CompilationPipeline.assemblyCompilationFinished -= CompilationPipeline_assemblyCompilationFinished;
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 CompilationPipeline公共类是用来做什么的
        //它是 Unity 编辑器中的一个公共类，用于处理代码编译相关的操作和事件的
        //对于我们来说，我们最常用的是利用它得知代码是否编译结束
        //比如动态生成脚本时，我们需要在编译结束后才能使用新的脚本 
        #endregion

        #region 知识点二 创建自定义面板用于进行知识讲解

        #endregion

        #region 知识点三 常用内容
        //1.CompilationPipeline.assemblyCompilationFinished
        //  命名空间：UnityEditor.Compilation;
        //  主要作用：当一个程序集编译结束会主动调用该回调函数
        //  传入的两个参数分别是
        //  string arg1 : 编译完成的程序集名
        //  CompilerMessage[] arg2 : 编译完成后产生的编译消息数组，包括编译警告和错误信息

        //2.CompilationPipeline.compilationFinished
        //  命名空间：UnityEditor.Compilation;
        //  主要作用：当所有程序集编译结束会主动调用该回调函数
        //  参数
        //  object obj: ActiveBuildStatus 活动生成状态对象
        #endregion

        #region 知识点四 更多内容
        //https://docs.unity3d.com/ScriptReference/Compilation.CompilationPipeline.html
        #endregion
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
