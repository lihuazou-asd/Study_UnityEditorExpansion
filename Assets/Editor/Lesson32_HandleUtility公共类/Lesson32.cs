using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson32 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ�ع� ��ȡ���������λ��
        //Event.current.mousePosition
        #endregion

        #region ֪ʶ��һ HandleUtility���������Ҫ����
        //HandleUtility�� Unity �е�һ��������
        //���ڴ������еı༭�������Handles���Լ�����һЩ��༭��������صĹ���
        //���ṩ��һϵ�о�̬���������ڴ���༭���е���꽻��������ת���Լ�������Handles��صĹ���
        #endregion

        #region ֪ʶ��� HandleUtility���еĳ���API
        //1.GetHandleSize(Vector3 position)
        //  ����֮ǰ�Ѿ�ʹ�ù���API
        //  ��ȡ�ڳ����и���λ�õľ���ĺ��ʳߴ�
        //  ������ͨ�����ڸ��ݳ����ж���ľ�������������Ĵ�С���Ա��ڲ�ͬ�����ż����±��ֺ��ʵ���ʾ��С

        //2.WorldToGUIPoint(Vector3 worldPosition)
        //  ����������ת��Ϊ GUI ����
        //  �������ͨ�����ڽ������е�ĳ�����λ��ת��Ϊ��Ļ�ϵ���������
        //  �Ա��� GUI �л�����ص���Ϣ

        //3.GUIPointToWorldRay(Vector2 position)
        //  ����Ļ�ϵ���������ת��Ϊ����
        //  �������ͨ�����ڴ���Ļ�����л�ȡһ�����ߣ����ڼ�ⳡ���е�������������Ͷ��

        //4.DistanceToLine(Vector3 lineStart, Vector3 lineEnd)
        //  ���㳡����һ���߶�����������̾���
        //  ��������������ͣ��ɫ�ȹ���

        //5.PickGameObject(Vector2 position, bool isSelecting)
        //  �ڱ༭���н��ж����ʰȡ
        //  �������ͨ�����ڸ��������λ�û�ȡ�����еĶ�����ʵ�ֶ����ѡ��򽻻�����
        #endregion

        #region ֪ʶ���� ��������
        //https://docs.unity3d.com/ScriptReference/HandleUtility.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
