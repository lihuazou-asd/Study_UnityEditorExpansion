using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson30 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ�ع�
        //HandleUtility.GetHandleSize
        //���ڻ�ȡ�� Scene �����е�һ����λ��������Ӧ����Ļ�ռ��С
        //���������Ҫ���ڸ�������ľ�������̬���������ֱ��Ĵ�С
        //ʹ���ڲ�ͬ�������ܹ�����ͼ����ʾ���ʵĴ�С
        //һ�����ǰѶ���λ�ô��ݽ�ȥ�������Զ��õ�һ�������С
        #endregion

        #region ֪ʶ��һ Handles�е������ƶ�
        //һ������Լ�����ƶ����Ʊ�
        //������ֿ��������з����������ƶ�
        //Vector3 Handles.FreeMoveHandle(λ��, �����С, �ƶ�����ֵ(��סctrl��ʱ�ᰴ�õ�λ�ƶ�), ��Ⱦ�����ֱ��Ļص�����);
        //�����Сһ�����HandleUtility.GetHandleSize����ʹ��

        //��Ⱦ�����ֱ��ĳ��ûص�����:
        //Handles.RectangleHandleCap:һ��������״�Ŀ����ֱ���ͨ�����ڱ�ʾһ��ƽ��Ŀ�����
        //Handles.CircleHandleCap:һ��Բ�εĿ����ֱ���ͨ�����ڱ�ʾһ������Ŀ�����
        //Handles.ArrowHandleCap:һ����ͷ��״�Ŀ����ֱ���ͨ�����ڱ�ʾ����
        #endregion

        #region ֪ʶ��� Handles�е�������ת
        //Quaternion Handles.FreeRotateHandle(�Ƕ�, λ��, �����С);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
