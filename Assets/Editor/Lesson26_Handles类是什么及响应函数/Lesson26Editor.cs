using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Lesson26))]
public class Lesson26Editor : Editor
{
    private Lesson26 obj;

    private void OnEnable()
    {
        obj = target as Lesson26;
    }

    private void OnSceneGUI()
    {
        Debug.Log("Scene������չ����߼�");

        #region Lesson27 �ı����߶Ρ�����
        //��ɫ
        Handles.color = new Color(0, 1, 0, 1f);
        //�ı�
        Handles.Label(obj.transform.position, "�����ı���ʾ");
        //�߶�
        Handles.DrawLine(obj.transform.position, obj.transform.position + obj.transform.right * 5, 5);
        //����
        Handles.color = new Color(0, 0, 1, 1f);
        Handles.DrawDottedLine(obj.transform.position, obj.transform.position + obj.transform.forward * 5, 5);
        #endregion

        #region Lesson28 ���ߡ�Բ�������壬������
        //���ߣ�Բ����
        Handles.color = Color.white;
        Handles.DrawWireArc(obj.transform.position, Vector3.up, obj.transform.forward, 30, 5);
        Handles.DrawSolidArc(obj.transform.position, obj.transform.up, Quaternion.Euler(0,-15,0)* obj.transform.forward, 30, 4);
        //Բ
        Handles.color = Color.gray;
        Handles.DrawSolidDisc(obj.transform.position, obj.transform.up, 2);
        Handles.DrawWireDisc(obj.transform.position, obj.transform.up, 3);
        //������
        Handles.color = Color.red;
        Handles.DrawWireCube(obj.transform.position, Vector3.one);
        //������
        //(0,0,0)
        //(1,0,0)
        //(1,0,1)
        //(0,0,z)
        Handles.DrawAAConvexPolygon(Vector3.zero, Vector3.right, Vector3.right + Vector3.forward, Vector3.forward);
        #endregion

        #region Lesson29 �ƶ�����ת������
        //�ƶ�
        obj.transform.position = Handles.DoPositionHandle(obj.transform.position, obj.transform.rotation);
        //obj.transform.position = Handles.PositionHandle(obj.transform.position, obj.transform.rotation);
        //��ת
        obj.transform.rotation = Handles.DoRotationHandle(obj.transform.rotation, obj.transform.position) ;
        //obj.transform.rotation = Handles.RotationHandle(obj.transform.rotation, obj.transform.position);
        //����
        obj.transform.localScale = Handles.DoScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
                                                         HandleUtility.GetHandleSize(obj.transform.position));

        //obj.transform.localScale = Handles.ScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
        //                                                 HandleUtility.GetHandleSize(Vector3.zero));
        #endregion

        #region Lesson30 �����ƶ���������ת
        //�����ƶ�
        obj.transform.position = Handles.FreeMoveHandle(obj.transform.position, HandleUtility.GetHandleSize(obj.transform.position),
                                                        Vector3.one*5, Handles.CircleHandleCap);

        //������ת
        obj.transform.rotation = Handles.FreeRotateHandle(obj.transform.rotation, Vector3.zero, HandleUtility.GetHandleSize(Vector3.zero));
        #endregion

        #region Lesson31 ��ʾGUI
        Handles.BeginGUI();
        if(GUILayout.Button("���԰�ť"))
        {
            Debug.Log("Scene�еİ�ť��Ӧ");
        }

        float w = SceneView.currentDrawingSceneView.position.width;
        float h = SceneView.currentDrawingSceneView.position.height;
        
        GUILayout.BeginArea(new Rect(w - 100, h - 100, 100, 100));
        GUILayout.Label("�����ı��ؼ���ʾ");
        if (GUILayout.Button("���԰�ť"))
        {
            Debug.Log("Scene�еİ�ť��Ӧ");
        }
        GUILayout.EndArea();

        Handles.EndGUI();
        #endregion

        #region Lesson32 HandleUtility����API
        //1.GetHandleSize(Vector3 position)
        //  ֮ǰѧϰ�� ���Բ���Ҫ����
        //2.WorldToGUIPoint(Vector3 worldPosition)
        Vector2 pos = HandleUtility.WorldToGUIPoint(obj.transform.position);
        Handles.BeginGUI();
        GUI.Button(new Rect(pos.x, pos.y, 50, 20), "���԰�ť");
        Handles.EndGUI();

        //3.GUIPointToWorldRay(Vector2 position)
        Ray r = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
        RaycastHit info;
        if (Physics.Raycast(r, out info))
            Debug.Log(info.collider.name);

        //4.DistanceToLine(Vector3 lineStart, Vector3 lineEnd)
        float dis = HandleUtility.DistanceToLine(Vector3.zero, Vector3.right);
        //Debug.Log(dis);

        //5.PickGameObject(Vector2 position, bool isSelecting)
        GameObject testObj = HandleUtility.PickGameObject(Event.current.mousePosition, true);
        if(testObj != null)
            Debug.Log("ѡ���������֣�" + testObj.name);
        #endregion
    }
}
