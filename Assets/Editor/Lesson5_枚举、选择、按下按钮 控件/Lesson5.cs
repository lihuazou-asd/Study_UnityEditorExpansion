using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ö��ѡ��ؼ�
        //ö��ѡ��
        //  ö�ٱ��� = (ö������)EditorGUILayout.EnumPopup("ö��ѡ��", ö�ٱ���);

        //��ѡö��
        //(ע�⣺��ѡö�ٽ��е��ǻ����㣬����ö��ʱһ��ע�����еĸ�ֵ������һ��Ҫ�ж�������Ĵ���ֵ)
        //  ö�ٱ��� = (ö������)EditorGUILayout.EnumFlagsField("ö�ٶ�ѡ", ö�ٱ���);
        #endregion

        #region ֪ʶ��� ����ѡ��ؼ�
        //int���� = EditorGUILayout.IntPopup("������ѡ��", int����, �ַ�������, int����);
        #endregion

        #region ֪ʶ���� ���¾ʹ����İ�ť�ؼ�
        //EditorGUILayout.DropdownButton(new GUIContent("��ť������"), FocusType.Passive)

        //FocusTypeö��ʱ����UIϵͳ�ܹ���ü��̽��� ���û���Tab��ʱ�ڿؼ�֮������л�
        //Keyboard	�ÿؼ��ɽ��ռ��̽��㡣
        //Passive �ÿؼ����ܽ��ռ��̽��㡣
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
