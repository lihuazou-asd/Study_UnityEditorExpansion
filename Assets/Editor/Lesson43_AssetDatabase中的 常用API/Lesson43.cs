using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson43 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ AssetDatabase�еĳ���API
        //1.������Դ,���ǿ���ͨ�����붯̬����һЩ��Դ
        //  ·���� Assets/...��ʼ
        //  AssetDatabase.CreateAsset(��Դ,·��);
        //  ע�⣺
        //  ������StreamingAssets�д�����Դ��
        //  ���ܴ���Ԥ���壨Ԥ���崴��֮��ὲ����
        //  ֻ�ܴ�����Դ��أ�����������
        //  ·����Ҫд��׺

        //2.�����ļ��У�·���� Assets/...��ʼ
        //  AssetDatabase.CreateFolder(���ļ��У����ļ�����)

        //3.������Դ��·���� Assets/...��ʼ
        //  AssetDatabase.CopyAsset(Դ��Դ��Ŀ��·��)
        //  ע�⣺
        //  ��Ҫд��׺��

        //4.�ƶ���Դ��·���� Assets/...��ʼ
        //  AssetDatabase.MoveAsset(��·��, ��·��);

        //5.ɾ����Դ��·���� Assets/...��ʼ
        //  AssetDatabase.DeleteAsset(��Դ·��)

        //6.����ɾ����Դ��·���� Assets/...��ʼ
        //  AssetDatabase.DeleteAssets(string[] ·����, List<string> ���ڴ洢ɾ��ʧ�ܵ�·��)

        //7.��ȡ��Դ·�� �������Selectionѡ����Դһ��ʹ��
        //  AssetDatabase.GetAssetPath(��Դ)

        //8.����·��������Դ��·����Assets/��ʼ
        //  AssetDatabase.LoadAssetAtPath(��Դ·��)

        //9.����·������������Դ��·����Assets/��ʼ
        //  AssetDatabase.LoadAllAssetsAtPath(��Դ·��);
        //  һ�������������ͼ����Դ������ֵΪObject����
        //  �����ͼ������һ��Ϊͼ������֮��ı���ͼ���е�����Sprite

        //10.ˢ�£�������Դ�����ƶ������롢ɾ���Ȳ�������Ҫִ��ˢ��
        //  AssetDatabase.Refresh()

        //11.������Դ������AB������·����Assets/��ʼ
        //  GetImplicitAssetBundleName����Դ·��);
        #endregion

        #region ֪ʶ��� ��������
        //https://docs.unity3d.com/ScriptReference/AssetDatabase.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
