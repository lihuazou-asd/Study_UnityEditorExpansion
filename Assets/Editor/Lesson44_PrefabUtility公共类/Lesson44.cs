using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson44 : EditorWindow
{

    [MenuItem("Unity�༭����չ/Lesson44/PrefabUtility֪ʶ�㽲��")]
    private static void OpenLesson44()
    {
        Lesson44 win = EditorWindow.GetWindow<Lesson44>("PrefabUtility֪ʶ�㽲��");
        win.Show();
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ PrefabUtility��������ʲô
        //���� Unity �༭���е�һ��������
        //�ṩ��һЩ���ڴ��� Prefab��Ԥ������Ԥ���壩�ķ���
        //��Ҫ���ܰ��� ʵ����Ԥ���塢����Ԥ���塢�޸�Ԥ���� �ȵ�

        //ֻҪ���ж�Ԥ����������������
        //�������ڱ༭���������κεط��������ʹ��
        #endregion

        #region ֪ʶ��� �����Զ���������ڽ���֪ʶ����

        #endregion

        #region ֪ʶ���� ����API 
        //1.��̬����Ԥ���� ·����Assets/...��ʼ
        //  PrefabUtility.SaveAsPrefabAsset(GameObject����, ·��);

        //2.����Ԥ������󣨲������ڴ�����һ�������޸ģ����Ԥ������ص��ڴ��У�
        //  ·����Assets/...��ʼ
        //  PrefabUtility.LoadPrefabContents(·��)
        //  �ͷż��ص�Ԥ�������
        //  PrefabUtility.UnloadPrefabContents(GameObject����)
        //  ע�⣺������������Ҫ���ʹ�ã������˾�Ҫд��

        //3.�޸�����Ԥ���� 
        //  PrefabUtility.SavePrefabAsset(Ԥ�������, out bool �Ƿ񱣴�ɹ�);
        //  �������AssetDatabase.LoadAssetAtPathʹ��

        //4.ʵ����Ԥ����
        //  PrefabUtility.InstantiatePrefab(Object����)
        #endregion

        #region ֪ʶ���� ��������
        //https://docs.unity3d.com/2022.3/Documentation/ScriptReference/PrefabUtility.html
        #endregion
    }

    private void OnGUI()
    {
        //1.��̬����Ԥ���� ·����Assets/...��ʼ
        //  PrefabUtility.SaveAsPrefabAsset(GameObject����, ·��);
        if(GUILayout.Button("��̬����Ԥ����"))
        {
            GameObject obj = new GameObject();
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<BoxCollider>();
            PrefabUtility.SaveAsPrefabAsset(obj, "Assets/Resources/TestObj.prefab");
            DestroyImmediate(obj);
        }

        //2.����Ԥ������󣨲������ڴ�����һ�������޸ģ����Ԥ������ص��ڴ��У�
        //  ·����Assets/...��ʼ
        //  PrefabUtility.LoadPrefabContents(·��)
        //  �ͷż��ص�Ԥ�������
        //  PrefabUtility.UnloadPrefabContents(GameObject����)
        //  ע�⣺������������Ҫ���ʹ�ã������˾�Ҫ�ͷ�

        //����ļ��� ��������ʵ�Ѿ���Ԥ���������ʵ������ ֻ������ʵ�������󲢲����ڴ�ͳ��Scene�����У�����һ���������Ķ����ĳ����У�
        if (GUILayout.Button("����Ԥ�������"))
        {
            //���� ���ڴ��� ��������ʵ���� һ����س����ǽ����޸ĵ�
            GameObject testObj = PrefabUtility.LoadPrefabContents("Assets/Resources/TestObj.prefab");
            testObj.AddComponent<MeshRenderer>();
            //���ּ��ط�ʽ �ǿ��Խ��нű��Ƴ� �Ӷ��󴴽���
            DestroyImmediate(testObj.GetComponent<MeshRenderer>());
            GameObject obj = new GameObject("�½��Ӷ���");
            obj.transform.parent = testObj.transform;
            PrefabUtility.SaveAsPrefabAsset(testObj, "Assets/Resources/TestObj.prefab");
            //�ͷ� һ��Ҫ���ʹ��
            PrefabUtility.UnloadPrefabContents(testObj);
        }

        //3.�޸�����Ԥ���� 
        //  PrefabUtility.SavePrefabAsset(Ԥ�������, out bool �Ƿ񱣴�ɹ�);
        //  �������AssetDatabase.LoadAssetAtPathʹ��
        if (GUILayout.Button("�޸�����Ԥ���� "))
        {
            GameObject testObj = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/TestObj.prefab");
            testObj.AddComponent<BoxCollider>();
            //����������ܴ洢ʵ����������� ֻ�ܴ洢��Ӧ��Ԥ�������
            PrefabUtility.SavePrefabAsset(testObj);
        }

        //4.ʵ����Ԥ����
        //  PrefabUtility.InstantiatePrefab(Object����)
        if (GUILayout.Button("ʵ����Ԥ����"))
        {
            GameObject testObj = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/TestObj.prefab");
            PrefabUtility.InstantiatePrefab(testObj);

        }
    }
}
