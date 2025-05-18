using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum E_TestType
{
    One = 1,
    Two = 2,
    Three = 4,
    One_and_Two = 1 | 2,
}

public class Lesson3 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson3/EditorGUI֪ʶ���ⴰ��")]
    private static void OpenLesson3()
    {
        Lesson3 win = EditorWindow.GetWindow<Lesson3>("EditorGUI֪ʶ���ⴰ��");
        //win.titleContent = new GUIContent("EditorGUI֪ʶ���ⴰ��");
        win.Show();
    }
    int layer;
    string tag;
    Color color;

    E_TestType type;
    E_TestType type2;

    string[] strs = { "ѡ��123", "ѡ��234", "ѡ��345" };
    int[] ints = { 123, 234, 345 };
    int num = 0;

    GameObject obj;

    int i;
    int i2;
    float f;
    double d;
    long l;

    string str;
    Vector2 vec2;
    Vector3 vec3;
    Vector4 vec4;

    Rect rect;
    Bounds bounds;
    BoundsInt boundsInt;

    bool isHide;
    bool isHideGroup;

    bool isTog;
    bool isTogLeft;

    bool isTogGroup;

    float fSlider;
    int iSlider;

    float leftV;
    float rightV;

    AnimationCurve curve = new AnimationCurve();

    Vector2 vec2Pos;

    private void OnGUI()
    {
        //�����еĿؼ���ػ��� �߼�������ص�����
        //EditorGUI��صĿؼ� ͬ��������Ҫ��OnGUI���н���ʵ�� ���ܱ���ʾ����
        #region Lesson4 �ı��ؼ����㼶��ǩ�ؼ�����ɫ��ȡ�ؼ�
        //�ı��ؼ�
        EditorGUILayout.LabelField("�ı�����", "��������");
        EditorGUILayout.LabelField("�ı�����");
        //�㼶��ǩ�ؼ�
        layer = EditorGUILayout.LayerField("�㼶ѡ��", layer);
        tag = EditorGUILayout.TagField("��ǩѡ��", tag);
        //��ɫ��ȡ�ؼ�
        color = EditorGUILayout.ColorField(new GUIContent("�Զ�����ɫ��ȡ"), 
                                            color, true, false, false);
        #endregion

        #region Lesson5 ö��ѡ������ѡ�񡢰��¾ʹ����İ�ť

        isHide = EditorGUILayout.Foldout(isHide, "�۵��ؼ�", false);

        if(isHide)
        {
            //ö��ѡ��
            type = (E_TestType)EditorGUILayout.EnumPopup("ö��ѡ��", type);

            type2 = (E_TestType)EditorGUILayout.EnumFlagsField("ö�ٶ�ѡ", type2);

            //����ѡ��ؼ�
            //����ֵ ��ʵ���������鵱�е�ĳһ��ֵ
            num = EditorGUILayout.IntPopup("������ѡ��", num, strs, ints);
            EditorGUILayout.LabelField(num.ToString());

            //���¾���Ӧ�İ�ť
            if (EditorGUILayout.DropdownButton(new GUIContent("��ť������"), FocusType.Passive))
                Debug.Log("���¾���Ӧ");
        }
        #endregion

        #region Lesson7 �۵����۵���ؼ�
        isHideGroup = EditorGUILayout.BeginFoldoutHeaderGroup(isHideGroup, "�۵���ؼ�");
        if (isHideGroup)
        {
            #region Lesson6 �������������������
            //�������
            obj = EditorGUILayout.ObjectField("������Դ����", obj, typeof(GameObject), false) as GameObject;
            //����������
            i = EditorGUILayout.IntField("Int�����", i);
            EditorGUILayout.LabelField(i.ToString());
            l = EditorGUILayout.LongField("long�����", l);
            f = EditorGUILayout.FloatField("Float ���룺", f);
            d = EditorGUILayout.DoubleField("double ���룺", d);

            str = EditorGUILayout.TextField("Text���룺", str);
            vec2 = EditorGUILayout.Vector2Field("Vec2���룺 ", vec2);
            vec3 = EditorGUILayout.Vector3Field("Vec3���룺 ", vec3);
            vec4 = EditorGUILayout.Vector4Field("Vec4���룺 ", vec4);

            rect = EditorGUILayout.RectField("rect���룺 ", rect);
            bounds = EditorGUILayout.BoundsField("Bounds���룺 ", bounds);
            boundsInt = EditorGUILayout.BoundsIntField("Bounds���룺 ", boundsInt);

            //ע�⣺EditorGUILayout�л���һЩDelayed��ͷ������ؼ�
            //     ���Ǻ���ͨ����ؼ�����Ҫ�������ǣ����û��� Enter ���򽫽�����ֶ��ƿ�֮ǰ������ֵ�������
            i2 = EditorGUILayout.DelayedIntField("Int�����", i2);
            EditorGUILayout.LabelField(i2.ToString());
            #endregion
            vec2Pos = EditorGUILayout.BeginScrollView(vec2Pos); //����������ͼ

            #region Lesson8 ���ء�������ؼ�
            //������ؼ�
            isTogGroup = EditorGUILayout.BeginToggleGroup("������ؼ�", isTogGroup);
            //���ؿؼ�
            isTog = EditorGUILayout.Toggle("���ؿؼ�", isTog);
            isTogLeft = EditorGUILayout.ToggleLeft("��࿪��", isTogLeft);
            EditorGUILayout.EndToggleGroup();
            #endregion

            #region Lesson9 ��������˫�黬�����ؼ�
            //������
            fSlider = EditorGUILayout.Slider("������", fSlider, 0, 10);
            iSlider = EditorGUILayout.IntSlider("���λ�����", iSlider, 0, 10);
            //˫�黬����
            EditorGUILayout.MinMaxSlider("˫�黬����", ref leftV, ref rightV, 0, 10);
            EditorGUILayout.LabelField(leftV.ToString());
            EditorGUILayout.LabelField(rightV.ToString());
            #endregion

            #region Lesson10 �����򡢼���ؼ�
            //������ؼ�
            EditorGUILayout.HelpBox("һ����ʾ", MessageType.None);
            EditorGUILayout.Space(10);
            EditorGUILayout.HelpBox("��̾����ʾ", MessageType.Info);
            EditorGUILayout.Space(50);
            EditorGUILayout.HelpBox("���������ʾ", MessageType.Warning);
            EditorGUILayout.Space(100);
            EditorGUILayout.HelpBox("���������ʾ", MessageType.Error);
            //����ؼ�
            #endregion

            EditorGUILayout.EndScrollView(); //����������ͼ
        }
        EditorGUILayout.EndFoldoutHeaderGroup();
        #endregion

        #region Lesson11 �������߿ؼ��Ͳ���API
        //�������߿ؼ�
        curve = EditorGUILayout.CurveField("���߿ؼ�", curve);
        //����API
        EditorGUILayout.BeginHorizontal(); //��ʼˮƽ����
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.EndHorizontal();//����ˮƽ����

        EditorGUILayout.BeginVertical();//��ʼ��ֱ����
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.LabelField("123123");
        EditorGUILayout.EndVertical();//������ֱ����

        //vec2Pos = EditorGUILayout.BeginScrollView(vec2Pos); //����������ͼ
        ////һ��ѿؼ�
        //EditorGUILayout.EndScrollView(); //����������ͼ
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ�ع� �Լ� ׼������
        //1.֪ʶ�ع�
        //GUILayout ��һ��GUI�Զ����ֵĹ�����
        //�����еķ�����GUI����һģһ���������������ơ���Ӧ����UI�ؼ���
        //ֻ��������GUI�Ļ����ϼ������Զ����ֹ���
        //������������ȥ����UI�ؼ���λ�úʹ�С

        //GUILayoutOption ����ѡ��
        //�ؼ��Ĺ̶����
        //GUILayout.Width(300);
        //GUILayout.Height(200);
        //����ؼ�����С���
        //GUILayout.MinWidth(50);
        //GUILayout.MinHeight(50);
        //����ؼ��������
        //GUILayout.MaxWidth(100);
        //GUILayout.MaxHeight(100);
        //������ֹˮƽ��չ
        //GUILayout.ExpandWidth(true);//����
        //GUILayout.ExpandHeight(false);//��ֹ
        //GUILayout.ExpandHeight(true);//����
        //GUILayout.ExpandHeight(false);//��ֹ

        //2.׼������
        //����һ���༭������ 
        #endregion

        #region ֪ʶ�� EditorGUI��ʲô��
        //EditorGUI ���� GUI
        //��һ����Ҫ���ڻ��Ʊ༭����չ UI �Ĺ�����
        //���ṩ��һЩ GUI ��û�е�API
        //��Ҫ�� �༭�������л��õ���һЩ ����ؼ�

        //��EditorGUILayout ������ GUILayout
        //��һ�������Զ����ֹ��ܵ� EditorGUI ���ƹ�����

        //���Ǿ����Ὣ EditorGUI �� GUI ���ʹ�� ������һЩ�༭����չ����
        //�������ڸ���ʱ�����ǻ��õ��Զ����ֹ���
        //������ǽ��������ؽ��� EditorGUILayout �еĹ���
        //EditorGUI�����������������Ҫ�Լ�����λ�ö���

        //��ϸ���ݣ�https://docs.unity.cn/cn/2022.3/ScriptReference/EditorGUILayout.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
