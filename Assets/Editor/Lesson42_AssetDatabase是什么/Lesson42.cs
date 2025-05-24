using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Lesson42 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson42/AssetDatabase֪ʶ�㽲��")]
    private static void OpenLesson42()
    {
        Lesson42 win = EditorWindow.GetWindow<Lesson42>("AssetDatabase֪ʶ�㽲��");
        win.Show();
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ AssetDatabase��������������ʲô�ģ�
        //���� Unity �����е�һ���༭����
        //�����ڱ༭�������й���Ͳ�����Ŀ�е���Դ��Assets��
        //���ṩ��һϵ�о�̬����
        //ʹ�ÿ������ܹ��ڱ༭���ű��н�����Դ�Ĵ������������ƶ���ɾ���Ȳ���
        #endregion

        #region ֪ʶ��� ������ʹ��AssetDatabase�������е��������
        //�ڱ༭����ش�������ʹ��AssetDatabase�������е��������
        //����Ҫ�ṩ����һЩ��Դ��صĸ������ܣ������ڱ༭����չ����������ط�ʹ��
        //��һ��ע�⣬�����ڱ༭�����ܣ��޷��������ȥ��ֻ����Unity�༭����ʹ��
        #endregion

        #region ֪ʶ���� ׼������
        //AssetDatabase�������κα༭�����ܿ���ʱʹ��
        //����Ϊ��֮���֪ʶ�㽲�������
        //����ͨ��һ���Զ��崰��������֪ʶ����
        #endregion
    }

    private void OnGUI()
    {
        //1.������Դ,���ǿ���ͨ�����붯̬����һЩ��Դ
        //  ·���� Assets/...��ʼ
        //  AssetDatabase.CreateAsset(��Դ,·��);
        //  ע�⣺
        //  ������StreamingAssets�д�����Դ��
        //  ���ܴ���Ԥ���壨Ԥ���崴��֮��ὲ����
        //  ֻ�ܴ�����Դ��أ�����������
        //  ·����Ҫд��׺
        if(GUILayout.Button("������Դ"))
        {
            Material mat = new Material(Shader.Find("Specular"));
            AssetDatabase.CreateAsset(mat, "Assets/Resources/MyMaterial.mat");
        }

        //2.�����ļ��У�·���� Assets/...��ʼ
        //  AssetDatabase.CreateFolder(���ļ��У����ļ�����)
        if (GUILayout.Button("�����ļ���"))
        {
            AssetDatabase.CreateFolder("Assets/Resources", "MyTestFolder");
        }

        //3.������Դ��·���� Assets/...��ʼ
        //  AssetDatabase.CopyAsset(Դ��Դ��Ŀ��·��)
        //  ע�⣺
        //  ��Ҫд��׺��
        if (GUILayout.Button("������Դ"))
        {
            AssetDatabase.CopyAsset("Assets/Editor Default Resources/EditorTeach.png", "Assets/Resources/MyTestFolder/EditorTeach.png");
        }

        //4.�ƶ���Դ��·���� Assets/...��ʼ
        //  AssetDatabase.MoveAsset(��·��, ��·��);
        if (GUILayout.Button("�ƶ���Դ"))
        {
            AssetDatabase.MoveAsset("Assets/Resources/MyTestFolder/EditorTeach.png", "Assets/Resources/EditorTeach.png");
        }

        //5.ɾ����Դ��·���� Assets/...��ʼ
        //  AssetDatabase.DeleteAsset(��Դ·��)
        if (GUILayout.Button("ɾ����Դ"))
        {
            AssetDatabase.DeleteAsset("Assets/Resources/EditorTeach.png");
        }

        //6.����ɾ����Դ��·���� Assets/...��ʼ
        //  AssetDatabase.DeleteAssets(string[] ·����, List<string> ���ڴ洢ɾ��ʧ�ܵ�·��)
        if (GUILayout.Button("����ɾ����Դ"))
        {
            List<string> failList = new List<string>();
            AssetDatabase.DeleteAssets(new string[] { "Assets/Resources/EditorTeach.png", "Assets/Resources/EditorTeach2.png" }, failList);
            for (int i = 0; i < failList.Count; i++)
            {
                Debug.Log(failList[i]);
            }
        }

        //7.��ȡ��Դ·�� �������Selectionѡ����Դһ��ʹ��
        //  AssetDatabase.GetAssetPath(��Դ)
        if (GUILayout.Button("��ȡ��Դ·��"))
        {
            Debug.Log(AssetDatabase.GetAssetPath(Selection.activeObject));
        }

        //8.����·��������Դ��·����Assets/��ʼ
        //  AssetDatabase.LoadAssetAtPath(��Դ·��)
        if (GUILayout.Button("������Դ"))
        {
            Texture txt = AssetDatabase.LoadAssetAtPath<Texture>("Assets/Resources/EditorTeach.png");
            Debug.Log(txt.name);
        }

        //9.����·������������Դ��·����Assets/��ʼ
        //  AssetDatabase.LoadAllAssetsAtPath(��Դ·��);
        //  һ�������������ͼ����Դ������ֵΪObject����
        //  �����ͼ������һ��Ϊͼ������֮��ı���ͼ���е�����Sprite
        //if (GUILayout.Button(""))
        //{
        //    //AssetDatabase.LoadAllAssetsAtPath(��Դ·��);
        //}

        //10.ˢ�£�������Դ�����ƶ������롢ɾ���Ȳ�������Ҫִ��ˢ��
        //  AssetDatabase.Refresh()
        if (GUILayout.Button("����ˢ��"))
        {
            File.WriteAllText(Application.dataPath + "/Resources/test2.txt", "123123123");
            AssetDatabase.Refresh();
        }

        //11.������Դ������AB������·����Assets/��ʼ
        //  GetImplicitAssetBundleName����Դ·��);
        //if (GUILayout.Button(""))
        //{

        //}
    }
}
