using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson35 : MonoBehaviour
{
    public Texture pic;
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ Gizmos������ͼ
        //Gizmos.DrawGUITexture(new Rect(x, y, w, h), ͼƬ��Ϣ);
        #endregion

        #region ֪ʶ��� Gizmos����ͼ��
        //ͼ����Ҫ�����ڹ̶��ļ�����
        //Assets/Gizmos/��

        //Gizmos.DrawIcon(Vector3.up, "ͼ����");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        //if(pic != null)
        //    Gizmos.DrawGUITexture(new Rect(this.transform.position.x, this.transform.position.y, 160, 90), pic);

        Gizmos.DrawIcon(this.transform.position, "MyIcon");
    }

}
