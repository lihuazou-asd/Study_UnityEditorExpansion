using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ��ʾ �ļ� �洢���
        //ͨ�������ڱ༭���б����´������ļ���ѡ���ļ��ı���·��
        //string path = EditorUtility.SaveFilePanel("���ڱ���", "�򿪵�Ŀ¼", "������ļ�������", "�ĺ�׺��ʽ")
        #endregion

        #region ֪ʶ��� ��ʾ �ļ� �洢���(Ĭ��ָ����Asset�ļ�����)
        //�� SaveFilePanel ���ƣ�������������·����������ĿĿ¼�У�ֻ�����û�ѡ����Ŀ�ڵ��ļ�����Ϊ����·��
        //string path = EditorUtility.SaveFilePanelInProject("���ڱ���", "������ļ�������", "��׺��ʽ", "�ڶԻ��򴰿�����ʾ���ı�ժҪ");
        #endregion

        #region ֪ʶ���� ��ʾ �ļ��� �洢���
        //ͨ�������ڱ༭����ѡ���ļ�����Ϊ����·�������ڱ����ļ���ִ���������ļ�����صĲ���
        //string path = EditorUtility.SaveFolderPanel("���ڱ���", "�ļ���", "Ĭ������");
        #endregion

        #region ֪ʶ���� ��ʾ�� �ļ� ���
        //ͨ�������ڱ༭����ѡ���ļ����д򿪻�ִ���������ļ���صĲ���
        //string path = EditorUtility.OpenFilePanel("���ڱ���", "�ļ�·��", "��׺��ʽ");
        #endregion

        #region ֪ʶ���� ��ʾ�� �ļ��� ���
        //ͨ�������ڱ༭����ѡ���ļ��н��д򿪻�ִ���������ļ�����صĲ���
        //string path = EditorUtility.OpenFolderPanel("���ڱ���", "�ļ���", "Ĭ������");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
