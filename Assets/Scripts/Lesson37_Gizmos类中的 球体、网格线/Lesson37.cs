using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson37 : MonoBehaviour
{
    public Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Gizmos��������
        //Gizmos.DrawSphere(���ĵ�, �뾶);
        //Gizmos.DrawWireSphere(���ĵ�, �뾶);
        #endregion

        #region ֪ʶ��� Gizmos����������
        //Gizmos.DrawWireMesh(mesh, λ��, �Ƕ�);
        #endregion

        #region ֪ʶ���� ����Gizmos���
        //https://docs.unity3d.com/ScriptReference/Gizmos.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.transform.position, 2);
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(this.transform.position, 3);

        Gizmos.color = Color.yellow;
        if(mesh != null)
            Gizmos.DrawWireMesh(mesh, this.transform.position, this.transform.rotation);
    }
}
