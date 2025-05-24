using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Lesson38 : EditorWindow
{
    private GameObject objTest1;
    private float value;
    [MenuItem("Unity�༭����չ/Lesson38/EditorUtility֪ʶ����")]
    private static void OpenLesson38Win()
    {
        Lesson38 win = EditorWindow.GetWindow<Lesson38>("EditorUtility֪ʶ����");
        win.Show();
    }

    private void OnGUI()
    {
        #region Lesson39 �༭��Ĭ�ϴ������
        if(GUILayout.Button("��ʾ��ʾ����"))
        {
            if(EditorUtility.DisplayDialog("���Դ���", "ȷ��һ��Ҫ�����������", "һ��Ҫ��"))
            {
                Debug.Log("ȷ��Ҫ����������ȥ�����߼�");
            }
            else
            {
                Debug.Log("����˲�棬��ȥ��");
            }

            Debug.Log("������ʾ���");
        }

        if(GUILayout.Button("��ʾ������ʾ����"))
        {
            int result = EditorUtility.DisplayDialogComplex("������ʾ", "��ʾ��Ϣ", "ѡ��1", "�ر�", "ѡ��2");
            switch (result)
            {
                case 0:
                    Debug.Log("ѡ��1������");
                    break;
                case 1:
                    Debug.Log("�رռ�������");
                    break;
                case 2:
                    Debug.Log("ѡ��2������");
                    break;
                default:
                    break;
            }

            Debug.Log("����������ʾ���");
        }

        if(GUILayout.Button("��ʾ���½�����"))
        {
            value += 0.1f;
            EditorUtility.DisplayProgressBar("����������", "������������ʾ����", value);
            Debug.Log("������������ʾ���");
        }

        if(GUILayout.Button("�رս�����"))
        {
            value = 0;
            EditorUtility.ClearProgressBar();
        }

        #endregion

        #region Lesson40 �ļ�������
        //1.��ʾ�ļ��洢���
        if(GUILayout.Button("���ļ��洢���"))
        {
            string str = EditorUtility.SaveFilePanel("�����ҵ��ļ�", Application.dataPath, "Test", "txt");
            Debug.Log(str);
            if(str != "")
                File.WriteAllText(str, "123123123123123");
        }
        //2.��ʾ�ļ��洢��壨Ĭ��Ϊ����Ŀ¼�У�
        if(GUILayout.Button("���ļ��洢��壨���޹����ļ����£�"))
        {
            string str2 = EditorUtility.SaveFilePanelInProject("������Ŀ�ڵ��ļ�", "Test2", "png", "�Զ����ļ�");
            Debug.Log(str2);
        }
        //3.��ʾ�ļ��д洢���
        if (GUILayout.Button("��ʾ�ļ��д洢���"))
        {
            string str3 = EditorUtility.SaveFolderPanel("�õ�һ���洢·�����ļ��У�", Application.dataPath, "");
            Debug.Log(str3);
        }

        //4.��ʾ���ļ����
        if (GUILayout.Button("��ʾ���ļ����"))
        {
            string str4 = EditorUtility.OpenFilePanel("�õ�һ���ļ�·��", Application.dataPath, "txt");
            if(str4 != "")
            {
                string txt = File.ReadAllText(str4);
                Debug.Log(txt);
            }
        }

        //5.��ʾ���ļ������
        if (GUILayout.Button("��ʾ���ļ������"))
        {
            string str4 = EditorUtility.OpenFolderPanel("�õ�һ���ļ�·��", Application.dataPath, "");
            if (str4 != "")
            {
                Debug.Log(str4);
            }
        }

        #endregion

        #region Lesson41 ��������
        objTest1 = EditorGUILayout.ObjectField("��Ҫ���ҹ�����Դ�Ķ���", objTest1, typeof(GameObject), true) as GameObject;
        if(GUILayout.Button("����������Դ"))
        {
            Object[] objs = EditorUtility.CollectDependencies(new Object[] { objTest1 });
            Selection.objects = objs;
        }
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��ع�
        //����Ŀǰ�Ѿ�ѧϰ��
        //1.�Զ���˵�����չ
        //2.�Զ��崰����չ
        //3.EditorGUI��EditorGUIUtility���
        //4.Selection������
        //5.Event������
        //6.Inspector������չ
        //7.Scene������չ��Handles�����ࡢHandleUtility�����ࡢGizmos�����ࣩ
        #endregion

        #region ֪ʶ��һ EditorUtility��������������ʲô�ģ�
        //���� Unity �༭���е�һ��ʵ�ù�����
        //�ṩ��һϵ�����ڱ༭���ű����Զ���༭����ʵ�ù���
        #endregion

        #region ֪ʶ��� ������ʹ��EditorUtility�������е��������
        //�ڱ༭����ش�������ʹ��EditorUtility�������е��������
        //����Ҫ�ṩ����һЩ�������ܣ������ڱ༭����չ����������ط�ʹ��
        //��һ��ע�⣬�����ڱ༭�����ܣ��޷��������ȥ��ֻ����Unity�༭����ʹ��
        #endregion

        #region ֪ʶ���� ׼������
        //EditorUtility�������κα༭�����ܿ���ʱʹ��
        //����Ϊ��֮���֪ʶ�㽲�������
        //����ͨ��һ���Զ��崰��������֪ʶ����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
