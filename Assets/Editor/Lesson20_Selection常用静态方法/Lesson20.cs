using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �ж�ĳ�������Ƿ�ѡ��
        //Contains �ж�ĳ�������Ƿ�ѡ��
        #endregion

        #region ֪ʶ��� ɸѡ����
        //�ӵ�ǰѡ������У�ɸѡ����Ҫ������
        //Selection.GetFiltered(����, ɸѡģʽ)
        //Selection.GetFiltered<����>(ɸѡģʽ)

        //  ɸѡģʽ��SelectionMode
        //  Unfiltered: ������
        //  TopLevel: ֻ��ȡ���ϲ�����Ӷ��󲻻�ȡ
        //  Deep: �������Ӷ��󶼻�ȡ
        //  ExcludePrefab: �ų�Ԥ����
        //  Editable: ֻѡ��ɱ༭�Ķ���
        //  OnlyUserModifiable: ���û����޸ĵ�����
        //  Assets: ֻ������Դ�ļ����µ�����
        //  DeepAssets: ����������ļ��У����е�����Ҳ��ȡ
        //  ���Ҫ���� λ�� | ����
        #endregion

        #region ֪ʶ���� ��ѡ�б仯ʱ����õ�ί��
        //Selection.selectionChanged += ����;//ѡ�������仯ʱ����
        #endregion

        #region �ܽ�
        //Selection��������Ҫ�ǰ������ǻ�ȡ��ѡ��Ķ����
        //���ǿ�����������ѡ�ж������һЩ����

        //Selection������ ����API
        //https://docs.unity.cn/cn/2022.1/ScriptReference/Selection.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
