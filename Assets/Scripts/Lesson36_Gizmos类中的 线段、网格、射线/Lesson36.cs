using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson36 : MonoBehaviour
{
    public Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Gizmos�����߶�
        //Gizmos.DrawLine(���, �յ�);
        #endregion

        #region ֪ʶ��� Gizmos��������
        //Gizmos.DrawMesh(mesh, λ��, �Ƕ�);
        #endregion

        #region ֪ʶ���� Gizmos��������
        //Gizmos.DrawRay(���, ����); 
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.position + Vector3.one);
        Gizmos.color = Color.blue;
        if(mesh != null)
            Gizmos.DrawMesh(mesh, this.transform.position, this.transform.rotation);

        Gizmos.DrawRay(this.transform.position, this.transform.forward);
    }
}
