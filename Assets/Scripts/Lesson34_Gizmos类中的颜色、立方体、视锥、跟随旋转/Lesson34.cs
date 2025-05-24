using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson34 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Gizmos�޸���ɫ
        //Gizmos.color = Color.green;
        #endregion

        #region ֪ʶ��� Gizmos����������
        //Gizmos.DrawCube(���ĵ�, ��С);
        //Gizmos.DrawWireCube(���ĵ�, ��С);
        #endregion

        #region ֪ʶ���� Gizmos������׶
        //Gizmos.DrawFrustum(��������, FOV(Field of View,��Ұ)�Ƕ�, Զ����ƽ��, ������ƽ��, ��Ļ�����); 
        #endregion

        #region ֪ʶ���� ��θı�������ݵĽǶ�
        //�޸�Gizmos����ǰ�ľ���
        //Gizmos.matrix
        //Gizmos.matrix = Matrix4x4.TRS(λ��, �Ƕ�, ����);
        //��ԭ����
        //Gizmos.matrix = Matrix4x4.identity
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        //�����ƾ���ԭ
        Gizmos.matrix = Matrix4x4.identity;
        Gizmos.color = Color.green;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(this.transform.position, new Vector3(2, 1, 3));
        Gizmos.color = Color.yellow;
        Gizmos.DrawFrustum(this.transform.position, 30, 50, 0.5f, 1.7f);
        //�����ƾ����Ϊĳ������� �����Ϳ��Ը��� �ƶ� ��ת ������
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        //Gizmos.matrix = this.transform.localToWorldMatrix;
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(2, 1, 4));
    }
}
