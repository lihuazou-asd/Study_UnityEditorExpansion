using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson28 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Handles�еĻ���(Բ��)
        //�����߿���
        //Handles.DrawWireArc(Բ��, ����, ���Ƴ���, �Ƕ�, �뾶); 
        // ������仡��
        //Handles.DrawSolidArc(Բ��, ����, ���Ƴ���, �Ƕ�, �뾶); 
        #endregion

        #region ֪ʶ��� Handles�е�Բ
        //�������Բ
        //Handles.DrawSolidDisc(Բ��, ����, �뾶); 
        //�����߿�Բ
        //Handles.DrawWireDisc(Բ��, ����, �뾶); 
        #endregion

        #region ֪ʶ���� Handles�е��������߿�
        //Handles.DrawWireCube(���ĵ�, xyz��С);
        #endregion

        #region ֪ʶ���� Handles�еļ�����
        //Handles.DrawAAConvexPolygon(�����������);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
