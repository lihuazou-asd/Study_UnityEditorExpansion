using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �����¼�����
        //  Event e = EditorGUIUtility.CommandEvent("�¼���");
        //  ��ȡ����һ�����ں��øô��ڵ���SendEvent(e) 
        //  ����һ�������п���ͨ��
        //  Event.current.type == EventType.ExecuteCommand �ж�
        //  Event.current.commandName == "�¼���"�ж�

        //�ڴ����¼�ʱ ���Զ��������¼��Ĵ��ڴ� ���ܶ����Ƿ��м��������Ӧ������
        #endregion

        #region ֪ʶ��� ����ת��
        //  ��Ļ����ϵ��ԭ��Ϊ��Ļ���Ͻ�
        //  GUI����ϵ��ԭ��Ϊ��ǰ�������Ͻ�

        //  GUIToScreenPoint:�����GUIλ��ת��Ϊ��Ļ�ռ�
        //  GUIToScreenRect:��rect��GUIλ��ת��Ϊ��Ļ�ռ�

        //  ScreenToGUIPoint:�������Ļ�ռ�ת��ΪGUIλ��
        //  ScreenToGUIRect:��rect����Ļ�ռ�ת��ΪGUIλ��
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
