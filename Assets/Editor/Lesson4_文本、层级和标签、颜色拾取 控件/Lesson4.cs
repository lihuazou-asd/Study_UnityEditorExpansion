using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ EditorGUILayout�е��ı��ؼ�
        //EditorGUILayout.LabelField("�ı�����", "�ı�����");
        #endregion

        #region ֪ʶ��� EditorGUILayout�еĲ㼶����ǩѡ��
        //Layer
        //  int���� = EditorGUILayout.LayerField("�㼶ѡ��", int����);
        //Tag
        //  string���� = EditorGUILayout.TagField("��ǩѡ��", string����);
        #endregion

        #region ֪ʶ���� EditorGUILayout�е���ɫ��ȡ
        //color���� = EditorGUILayout.ColorField(new GUIContent("����"),
        //                                      color����, �Ƿ���ʾʰɫ��, �Ƿ���ʾ͸����ͨ��, �Ƿ�֧��HDR);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
