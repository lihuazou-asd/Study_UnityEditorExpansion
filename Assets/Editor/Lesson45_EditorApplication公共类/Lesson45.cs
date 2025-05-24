using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson45 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson45/EditorApplication֪ʶ����")]
    private static void OpenLesson45()
    {
        Lesson45 win = EditorWindow.GetWindow<Lesson45>("EditorApplication֪ʶ����");
        win.Show();
    }

    private void OnEnable()
    {
        EditorApplication.update += MyUpdate;
    }

    private void OnDestroy()
    {
        EditorApplication.update -= MyUpdate;
    }

    private void OnGUI()
    {
        if(GUILayout.Button("��ӡ·��"))
        {
            Debug.Log(EditorApplication.applicationContentsPath);
            Debug.Log(EditorApplication.applicationPath);
        }

        if (GUILayout.Button("����"))
        {
            EditorApplication.EnterPlaymode();
        }

        if (GUILayout.Button("ֹͣ����"))
        {
            EditorApplication.ExitPlaymode();
        }
    }


    // Update is called once per frame
    void MyUpdate()
    {
        if(EditorApplication.isPlaying)
        {
            Debug.Log("�������в���״̬");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ EditorApplication��������������ʲô�ģ�
        //���� Unity �༭���е�һ�������࣬����Ҫ�ṩ��һЩ�ͱ༭��������ص�һЩ����
        //���� �༭���¼����������š���ͣ�ȣ������������жϣ��Ƿ������С���ͣ�С������У�
        //     �༭�����벥��ģʽ���˳�����ģʽ �ȵȹ���
        #endregion

        #region ֪ʶ��� �����Զ���������ڽ���֪ʶ����

        #endregion

        #region ֪ʶ���� ����API
        //1.�����༭���¼�
        //  EditorApplication.update��ÿ֡�����¼������������ڱ༭����ִ��һЩ�߼�
        //  EditorApplication.hierarchyChanged���㼶��ͼ�仯�¼����������еĶ������仯ʱ����
        //  EditorApplication.projectChanged����Ŀ�仯�¼�������Ŀ�е���Դ�����仯ʱ����
        //  EditorApplication.playModeStateChanged���༭������״̬�仯ʱ����
        //  EditorApplication.pauseStateChanged���༭����ͣ״̬�仯ʱ����

        //2.����༭�������������
        //  EditorApplication.isPlaying���жϵ�ǰ�Ƿ�����Ϸ����״̬��
        //  EditorApplication.isPaused���жϵ�ǰ��Ϸ�Ƿ�����ͣ״̬��
        //  EditorApplication.isCompiling���ж�Unity�༭���Ƿ����ڱ������
        //  EditorApplication.isUpdating���ж�Unity�༭���Ƿ�����ˢ��AssetDatabase

        //3.��ȡUnityӦ�ó���·�����
        //  EditorApplication.applicationContentsPath��Unity��װĿ¼Data·��
        //  EditorApplication.applicationPath��Unity��װĿ¼��ִ�г���·��

        //4.���÷���
        //  EditorApplication.Exit(0)���˳�Unity�༭��
        //  EditorApplication.ExitPlaymode()���˳�����ģʽ���л����༭ģʽ
        //  EditorApplication.EnterPlaymode()�����벥��ģʽ
        #endregion

        #region ֪ʶ���� ��������
        //EditorApplication�� https://docs.unity3d.com/2022.3/Documentation/ScriptReference/EditorApplication.html
        //EditorSceneManager��https://docs.unity3d.com/2022.3/Documentation/ScriptReference/SceneManagement.EditorSceneManager.html
        #endregion
    }

}
