using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson25 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ�ع� SerizlizeField����
        //��˽���ֶο��Ա����л����ܹ���Unity��Inspector���ڱ�������
        #endregion

        #region ֪ʶ��һ �����Inspector���ڱ༭�ֵ��Ա
        //UnityĬ���ǲ�֧��Dictionary��Inspector���ڱ���ʾ��
        //����ֻ����������List�������飩��Ա���������Dictionary
        #endregion

        #region ֪ʶ��� ISerializationCallbackReceiver�ӿ�
        //�ýӿ���Unity�ṩ���������л��ͷ����л�ʱִ���Զ����߼��Ľӿ�
        //ʵ�ָýӿڵ����ܹ��ڶ������л������̻�Ӵ��̷����л�ʱִ��һЩ�������
        //�ӿ��к�����
        //OnBeforeSerialize: �ڶ������л�֮ǰ����
        //OnAfterDeserialize: �ڶ���Ӵ��̷����л������

        //����������Ҫ������List�洢Dictionary�ľ���ֵ
        //�൱���ֵ��е����������Ǵ洢������List�е�
        //����������Ҫ��
        //OnBeforeSerialize���л�֮ǰ����Dictionary������ݴ���List�н������л�
        //OnAfterDeserialize�����л�֮�󣺽�List�з����л����������ݴ洢��Dictionary��
        #endregion

        #region ֪ʶ���� ��������List��Inspector�������Զ���Dictionary��ʾ
        //����������Inspector��������ʾ����Ϣ��������Դ��List
        //�������ֻ��Ҫ����List��Inspector�������Զ�����ʾ����
        #endregion

        #region �ܽ�
        //����Unity�в�֧����Inspector����ֱ��ʹ��Dictionary
        //������ǿ�����������List�������飩����ӵı��Dictionary��Ա
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
