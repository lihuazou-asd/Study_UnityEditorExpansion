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

    private Texture img;
    private Texture img2;

    private Texture img3;

    private Color color;

    private AnimationCurve curve = new AnimationCurve();

    private void OnGUI()
    {
        #region Lesson13 ��Դ����
        //������Դ�������Դ�����ڷ���null)
        if(GUILayout.Button("���ر༭��ͼƬ��Դ"))
            img = EditorGUIUtility.Load("EditorTeach.png") as Texture;
        if (img != null)
            GUI.DrawTexture(new Rect(0, 50, 160, 90), img);

        //������Դ�������Դ�����ڻ�ֱ�ӱ���
        if (GUILayout.Button("���ر༭��ͼƬ��Դ"))
            img2 = EditorGUIUtility.LoadRequired("EditorTeach.png") as Texture;
        if (img2 != null)
            GUI.DrawTexture(new Rect(0, 150, 160, 90), img2);
        #endregion

        #region Lesson14 �������ѯ������ѡ����ʾ��ʾ
        //�������ѯ
        if(GUILayout.Button("���������ѯ����"))
        {
            EditorGUIUtility.ShowObjectPicker<Texture>(null, false, "Editor", 0);
        }

        if(Event.current.commandName == "ObjectSelectorUpdated")
        {
            img3 = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if(img3 != null)
                Debug.Log(img3.name);
        }
        else if(Event.current.commandName == "ObjectSelectorClosed")
        {
            img3 = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (img3 != null)
                Debug.Log("���ڹر� - " + img3.name);
        }

        //����ѡ����ʾ��ʾ
        if(GUILayout.Button("����ѡ�ж���"))
        {
            if (img3 != null)
                EditorGUIUtility.PingObject(img3);
        }
        #endregion

        #region Lesson15 �����¼����ݡ�����ת��
        //�����¼�����
        if(GUILayout.Button("�����¼�"))
        {
            //�����¼�
            Event e = EditorGUIUtility.CommandEvent("����ʨ���¼�");
            Lesson3 win = EditorWindow.GetWindow<Lesson3>();
            win.SendEvent(e);
        }

        //if(Event.current.type == EventType.ExecuteCommand)
        //{
        //    if(Event.current.commandName == "����ʨ���¼�")
        //    {
        //        Debug.Log("�յ�����ʨ���¼�");
        //    }
        //}

        //����ת��
        if(GUILayout.Button("����ת������"))
        {
            Vector2 v = new Vector2(10, 10);
            GUI.BeginGroup(new Rect(10, 10, 100, 100));
            //ת������ ��������ڲ�����غ����� ��ôλ�ú����ϲ��ֵ�ƫ�� �ٽ���ת��
            Vector2 screenPos = EditorGUIUtility.GUIToScreenPoint(v);
            GUI.EndGroup();
            Debug.Log("GUI:" + v + "Screen:" + screenPos);
        }


        #endregion

        #region Lesson16 ָ������ʹ�ö�Ӧ���ָ��
        EditorGUI.DrawRect(new Rect(0, 180, 100, 100), Color.green);
        EditorGUIUtility.AddCursorRect(new Rect(0, 180, 100, 100), MouseCursor.Text);
        #endregion

        #region Lesson17 ����ɫ�塢��������
        //����ɫ��
        color = EditorGUILayout.ColorField(new GUIContent("ѡȡ��ɫ"), color, true, true, true);

        EditorGUIUtility.DrawColorSwatch(new Rect(180, 180, 30, 30), Color.blue);

        //��������
        curve = EditorGUILayout.CurveField("��������", curve);
        EditorGUIUtility.DrawCurveSwatch(new Rect(0, 300, 100, 80), curve, null, Color.red, Color.white);
        #endregion
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
