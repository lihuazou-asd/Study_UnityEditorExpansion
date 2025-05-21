using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MyCustomPro
{
    public int i;
    public float f;
}

public class Lesson22 : MonoBehaviour, ISerializationCallbackReceiver
{
    //������
    public int atk;
    //������
    public float def;
    //�ж�Ŀ�����������Gameobject
    public GameObject obj;

    public string[] strs;
    public int[] ints;
    public GameObject[] gameObjects;

    public List<GameObject> listObjs;

    public MyCustomPro myCustom;

    public Dictionary<int, string> myDic = new Dictionary<int, string>() { { 1,"123"},{ 2,"234"} };

    [SerializeField]
    private List<int> keys = new List<int>();
    [SerializeField]
    private List<string> values = new List<string>();

    public void OnAfterDeserialize()
    {
        myDic.Clear();
        for (int i = 0; i < keys.Count; i++)
        {
            if (!myDic.ContainsKey(keys[i]))
                myDic.Add(keys[i], values[i]);
            else
                Debug.LogWarning("�ֵ�Dictionary�����в���������ͬ�ļ�");
        }
    }

    public void OnBeforeSerialize()
    {
        keys.Clear();
        values.Clear();
        foreach (var item in myDic)
        {
            keys.Add(item.Key);
            values.Add(item.Value);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Inspector�����Զ�����ʾָʲô��
        //�ҿ�����ȫ�Զ���ĳһ���ű���Inspector���ڵ������ʾ
        #endregion

        #region ֪ʶ��� SerializedObject��SerializedProperty������
        //SerializedObject �� SerializedProperty
        //��Ҫ������ Unity �༭���в������޸����л���������ԡ�
        //����ͨ�����Զ���༭����ʹ�ã��Դ��������ɶ��Ƶ��������

        //����ֻ��Ҫ��ס�򵥵Ĺ���
        //SerializedObject ����ű�����
        //SerializedProperty ����ű������е�����

        //SerializedObject: https://docs.unity.cn/cn/2022.1/ScriptReference/SerializedObject.html
        //SerializedProperty: https://docs.unity.cn/cn/2022.1/ScriptReference/SerializedProperty.html
        #endregion

        #region ֪ʶ���� �Զ��� �ű���Inspector��������ʾ������
        //�ؼ����裺
        //1.����Ϊĳһ���ű�ʵ��һ���Զ���ű������ҽű���Ҫ�̳�Editor
        //  һ��ýű�����Ϊ �Զ���ű��� + Editor
        //2.�ڸýű�ǰ��������
        //  �����ռ䣺UnityEditor
        //  ��������CustomEditor(��Ҫ�Զ���ű�������Type)
        //3.������ӦSerializedProperty���л����� ����
        //  ��Ҫͨ�������Զ���ű��еĳ�Ա���й���
        //  �������ü̳�Editor��ĳ�ԱserializedObject�е�FindProperty("��Ա������")����������Ӧ��Ա;
        //  ���磺SerializedProperty mySerializedProperty;
        //        mySerializedProperty = serializedObject.FindProperty("�Զ���ű��еĳ�Ա��");
        //  һ����OnEnable�����г�ʼ��
        //4.��дOnInspectorGUI����
        //  �ú���������Inspector��������ʾ������
        //  ֻ��Ҫ��������д���ݱ�����Զ��崰��
        //  ע�⣺���е��߼���Ҫ���������������֮��

        //  �������л�����ı�ʾ��ʽ
        //  serializedObject.Update();
        //  ֮��Ӧ�������޸�
        //  serializedObject.ApplyModifiedProperties();
        #endregion

        #region ֪ʶ���� ��ȡ�ű������Ķ���
        //Editor�е�target��Ա����
        #endregion

        #region �ܽ�
        //����Ϊ�̳�Editor�Ľű�
        //���[CustomEditor(typeof(��Ҫ�Զ���Inspector���ڵĽű�))]����
        //�ڸýű��а���һ���Ĺ�����б�д
        //���ΪInspector�����е�ĳ���ű��Զ��崰�ڲ���
        #endregion

        foreach (var item in myDic)
        {
            print($"Dic:{item.Key} - {item.Value}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
