using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �������ѯ
        //  ��Ҫ���ã�
        //  ����һ���������ڣ�����ѡ���Լ���Ҫ����Դ
        //  ��ҪAPI��
        //  EditorGUIUtility.ShowObjectPicker<��Դ����>(Ĭ�ϱ�ѡ�еĶ���, �Ƿ�������ҳ�������, "���Ҷ������ƹ���", 0);
        //  ����1. Ĭ�ϱ�ѡ�еĶ��������
        //  ����2. �Ƿ�������ҳ�������
        //  ����3. ���Ҷ������ƹ��ˣ����������normal��ָ�ļ���������normal�Ļᱻ��������
        //  ����4. controlID, Ĭ��д0

        //  ��ȡѡ�����
        //  ��ҪAPI��
        //  EditorGUIUtility.GetObjectPickerObject()

        //  �������������ڻ�ͨ�������¼�����ʽ
        //  ֪ͨ�������Ĵ��ڶ�����Ϣ�ı仯
        //  ͨ��Event��������Ի�ȡ�������ڷ��͸��Լ����¼�
        //  Event.current ��ȡ��ǰ�¼�
        //  commandName ��ȡ�¼����������
        //      ObjectSelectorUpdated ����ѡ�����仯ʱ����
        //      ObjectSelectorClosed ����ѡ�񴰿ڹر�ʱ����
        //  if(Event.current.commandName == "ObjectSelectorUpdated")
        //  {
        //    ��ѡ��������ʱ֪ͨ����
        //
        //  }
        //  else if (Event.current.commandName == "ObjectSelectorClosed")
        //  {
        //    ��ѡ�񴰿ڹر�ʱ֪ͨ����
        //  }
        #endregion

        #region ֪ʶ��� ����ѡ����ʾ
        //EditorGUIUtility.PingObject(��Ҫ��ʾѡ�еĶ���);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
