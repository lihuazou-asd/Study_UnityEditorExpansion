using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson26 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Handles�����������
        //Handles���ṩ�˺ܶ�API
        //�����ǿ�����Scene�����л������ǵ��Զ�������
        //����GUI��EditorGUI���ƣ�ֻ������ר���ṩ��Scene����ʹ��

        //��Ҫ��Scene��������ʾ�Զ�������
        //������Ҫ�ڶ�Ӧ����Ӧ�����н��д���
        #endregion

        #region ֪ʶ��� Scene���ڸ�����Ӧ����
        //�ؼ��㣺
        //ǰ�������� ���Զ���Inspector������ʾ���� һ��
        //1.����Ϊĳһ���ű�ʵ��һ���Զ���ű������ҽű���Ҫ�̳�Editor
        //  һ��ýű�����Ϊ �Զ���ű��� + Editor
        //2.�ڸýű�ǰ��������
        //  �����ռ䣺UnityEditor
        //  ��������CustomEditor(��Ҫ�Զ���ű�������Type)

        //3.�ڸýű���ʵ��void OnSceneGUI()����
        //  �÷�����������ѡ�й����Զ���ű��Ķ���ʱ�Զ�����
        //  ע�⣺ֻ��ѡ��ʱ�Ż�ִ�У�û��ѡ�в�ִ��
        #endregion

        #region ֪ʶ���� �Զ��崰���м���Scene���ڸ�����Ӧ����
        //�������Զ��崰����ʾʱ
        //���������¼�
        //SceneView.duringSceneGui += �¼�����
        //�������ػ�����ʱ�Ƴ��¼�
        //SceneView.duringSceneGui -= �¼�����
        #endregion

        #region �ܽ�
        //Scene������չ����
        //��Ҫ���ṩ���Զ���ű����Զ��崰�ڵ�
        //���ǲ��ö�Ӧ�Ĺ�����д���
        //�������֮��Ľ̳������ó���������Ӧ�������Զ���һЩScene���ڵ���ʾ����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
