using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson33 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Gizmos����������ʲô�ģ�
        //Gizmos��Handlesһ��
        //��������������չScene���ڵ�
        //��Gizmos���Handles��˵
        //����Ҫרע�ڻ��Ƹ����ߡ�ͼ�ꡢ��״��
        //��Handles��Ҫ�������Ʊ༭�������ֱ���
        #endregion

        #region ֪ʶ��� Gizmos��Ӧ����
        //�ڼ̳�MonoBehaviour�Ľű���ʵ�����º���
        //�����������ʹ��Gizmos������ͼ��ͼ��Ļ���
        //1.OnDrawGizmos() ��ÿ֡���ã����Ƶ�������ʱ������Scene�����п���
        //2.OnDrawGizmosSelected() �����ű�������GameObject��ѡ��ʱ�Ż�ÿ֡���û����������
        //���ǵ�ִ�������������ں�����Unity����������Զ�ִ��
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Debug.Log("Gizmos");
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Debug.Log("Gizmos2");
    //}
}
