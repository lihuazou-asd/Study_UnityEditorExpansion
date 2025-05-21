using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//ͨ��������ԣ����ǾͿ���ΪLesson22�ű��Զ���Inspector�����е���ʾ��
[CustomEditor(typeof(Lesson22))]
public class Lesson22Editor : Editor
{
    private SerializedProperty atk;
    private SerializedProperty def;
    private SerializedProperty obj;

    private SerializedProperty strs;
    private SerializedProperty ints;
    private SerializedProperty gameObjects;

    private SerializedProperty listObjs;

    private SerializedProperty myCustom;

    private SerializedProperty myCustomI;
    private SerializedProperty myCustomF;

    private SerializedProperty keys;
    private SerializedProperty values;

    private int dicCount;

    private int count;

    private bool foldOut;

    private void OnEnable()
    {
        atk = serializedObject.FindProperty("atk");
        def = serializedObject.FindProperty("def");
        obj = serializedObject.FindProperty("obj");

        //Ĭ�ϵõ��������List����Ϊ��
        strs = serializedObject.FindProperty("strs");
        ints = serializedObject.FindProperty("ints");
        gameObjects = serializedObject.FindProperty("gameObjects");
        listObjs = serializedObject.FindProperty("listObjs");

        myCustom = serializedObject.FindProperty("myCustom");
        //myCustomI = myCustom.FindPropertyRelative("i");
        //myCustomF = myCustom.FindPropertyRelative("f");

        myCustomI = serializedObject.FindProperty("myCustom.i");
        myCustomF = serializedObject.FindProperty("myCustom.f");

        keys = serializedObject.FindProperty("keys");
        values = serializedObject.FindProperty("values");

        //��ʼ����ǰ���� ���� ÿ��һ��ʼ����0
        count = listObjs.arraySize;

        dicCount = keys.arraySize;
    }

    //  �ú���������Inspector��������ʾ������
    //  ֻ��Ҫ��������д���ݱ�����Զ��崰��
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        serializedObject.Update();
        //�Զ���Inspector���ڵ�����
        foldOut = EditorGUILayout.BeginFoldoutHeaderGroup(foldOut, "��������");
        if(foldOut)
        {
            if(GUILayout.Button("�����Զ���Inspector����"))
            {
                Debug.Log(target.name);
            }
            EditorGUILayout.IntSlider(atk, 0, 100, "������");
            def.floatValue = EditorGUILayout.FloatField("������", def.floatValue);
            EditorGUILayout.ObjectField(obj, new GUIContent("�жԶ���"));

            EditorGUILayout.Space(10);

            //��������
            count = EditorGUILayout.IntField("List����", count);

            //�Ƿ�Ҫ���� �Ƴ�β��������
            //�Ӻ���ǰȥ�Ƴ� �����Ƴ����ɾ�
            //����������ʱ �Ż�������߼�
            for (int i = listObjs.arraySize - 1; i >= count; i--)
                listObjs.DeleteArrayElementAtIndex(i);

            //��������������Ҫ���õ�ÿһ������λ�õĶ���
            for (int i = 0; i < count; i++)
            {
                //ȥ�ж�����������LIst�������� ȥͨ���������ʽȥ����
                if (listObjs.arraySize <= i)
                    listObjs.InsertArrayElementAtIndex(i);

                SerializedProperty indexPro = listObjs.GetArrayElementAtIndex(i);
                EditorGUILayout.ObjectField(indexPro, new GUIContent($"����{i}"));
            }
            EditorGUILayout.Space(10);
        }

        EditorGUILayout.EndFoldoutHeaderGroup();


        EditorGUILayout.PropertyField(strs, new GUIContent("�ַ�������"));
        EditorGUILayout.PropertyField(ints, new GUIContent("��������"));
        EditorGUILayout.PropertyField(gameObjects, new GUIContent("��Ϸ��������"));
        //EditorGUILayout.PropertyField(listObjs, new GUIContent("��Ϸ����List"));

        EditorGUILayout.PropertyField(myCustom, new GUIContent("�ҵ��Զ�������"));

        myCustomI.intValue = EditorGUILayout.IntField("�Զ��������е�I", myCustomI.intValue);
        myCustomF.floatValue = EditorGUILayout.FloatField("�Զ��������е�F", myCustomF.floatValue);

        dicCount = EditorGUILayout.IntField("�ֵ�����", dicCount);
        //��������ʱ �Ѷ��ɾ��
        for (int i = keys.arraySize - 1; i >= dicCount; i--)
        {
            keys.DeleteArrayElementAtIndex(i);
            values.DeleteArrayElementAtIndex(i);
        }

        for (int i = 0; i < dicCount; i++)
        {
            //����������� ����
            if(keys.arraySize <= i)
            {
                keys.InsertArrayElementAtIndex(i);
                values.InsertArrayElementAtIndex(i);
            }
            //ȥ�������Զ����ֵ�Ե��޸�
            SerializedProperty indexKey = keys.GetArrayElementAtIndex(i);
            SerializedProperty indexValue = values.GetArrayElementAtIndex(i);
            EditorGUILayout.BeginHorizontal();
            indexKey.intValue = EditorGUILayout.IntField("�ֵ�ļ�", indexKey.intValue);
            indexValue.stringValue = EditorGUILayout.TextField("�ֵ��ֵ", indexValue.stringValue);
            EditorGUILayout.EndHorizontal();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
