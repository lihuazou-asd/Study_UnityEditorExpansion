using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson47 : AssetPostprocessor
{
    //�������
    //  ����������Դ֮ǰ���ã������޸�����ĵ�������
    void OnPreprocessTexture()
    {
        //1.��Դ�����������ã��Ե������Դ����ͳһ���ã�
        Debug.Log("�������ûص�" + assetPath);

        TextureImporter improter = assetImporter as TextureImporter;
        improter.textureType = TextureImporterType.Sprite;
        improter.mipmapEnabled = false;

    }
    //  ����������Դ֮����ã�������Ե����Ϊ����к������� �޸������ʽ���ߴ硢ѹ���ȵ�
    void OnPostprocessTexture(Texture2D texture)
    {
        //2.��Դ��������Ե������Դ����ͳһ��Ԥ����
        Debug.Log("�������ص�" + texture.name);
        EditorUtility.CompressTexture(texture, TextureFormat.ETC_RGB4, TextureCompressionQuality.Fast);
    }

    //ģ�����
    //  ����ģ����Դ֮ǰ���ã������޸�����ĵ�������
    void OnPreprocessModel()
    {
        ModelImporter improter = assetImporter as ModelImporter;
    }
    //  ����ģ����Դ֮����ã�������Ե����Ϊ����к������� �޸����񡢲��ʡ�������
    void OnPostprocessModel(GameObject obj)
    {

    }

    //��Ƶ���
    //  ������Ƶ��Դ֮ǰ���ã������޸�����ĵ�������
    void OnPreprocessAudio()
    {
        AudioImporter improter = assetImporter as AudioImporter;

    }
    //  ������Ƶ��Դ֮����ã�������Ե����Ϊ����к������� �޸���Ƶ��ʽ��������
    void OnPostprocessAudio(AudioClip clip)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ �����֪ʶ���ʲô�й�
        //����ѧ������֪ʶ��
        //��������Ҫ��Ͻ���ʹ�õ�
        //������Ҫ�����ڴ���
        //1.��Դ�����������ã��Ե������Դ����ͳһ���ã�
        //2.��Դ��������Ե������Դ����ͳһ��Ԥ����
        #endregion

        #region ֪ʶ��� AssetPostprocessor������
        //AssetPostprocessor(��Դ��������)
        //����Ҫ���ڴ�����Դ����ʱ��ͨ���߼�
        //���ǿ���ͨ���̳и���
        //��ʵ�����е�һЩ�ص��������Զ��崦����Դ
        //����һ���������´���
        //1.����ĳ��������Դ��ͨ������
        //2.��ĳ��������Դ����ͳһ�����Ĵ���

        //�̳�����ĳ������ԣ�
        //AssetImporter assetImporter����Ӧ���͵���Դ����������
        //string assetPath: ������Դ��·��

        //�̳�����ĳ��ûص������У�
        //�������
        //  void OnPreprocessTexture()
        //  ����������Դ֮ǰ���ã������޸�����ĵ�������
        //  void OnPostprocessTexture(Texture2D texture)
        //  ����������Դ֮����ã�������Ե����Ϊ����к������� �޸������ʽ���ߴ硢ѹ���ȵ�

        //ģ�����
        //  void OnPreprocessModel()
        //  ����ģ����Դ֮ǰ���ã������޸�����ĵ�������
        //  void OnPostprocessModel(GameObject obj)
        //  ����ģ����Դ֮����ã�������Ե����Ϊ����к������� �޸����񡢲��ʡ�������

        //��Ƶ���
        //  void OnPreprocessAudio()
        //  ������Ƶ��Դ֮ǰ���ã������޸�����ĵ�������
        //  void OnPostprocessAudio(AudioClip clip)
        //  ������Ƶ��Դ֮����ã�������Ե����Ϊ����к������� �޸���Ƶ��ʽ��������

        //�ȵȵȵ�
        //�������ݣ�https://docs.unity3d.com/ScriptReference/AssetPostprocessor.html

        //ע�⣺
        //���ֻ���ĳ����Դ�е�ĳЩ���ݽ��д���
        //�����Լ�����������
        #endregion

        #region ֪ʶ���� AssetImporter������
        //AssetImporter(��Դ������ ��)
        //���� �ض���Դ���͵���Դ�������Ļ���
        //���ṩ��һЩ���������ԣ��������ú͹�����Դ�ĵ�������
        //һ�����ǲ���ֱ��ʹ�ø��࣬����ͨ��ʹ�ü̳��������������õ�����Դ�������Ϣ
        //�����ǵ���һ����Դʱ����Inspector�����н��е��������
        //����ͨ���̳и��������ʵ�ֵ�

        //��������һ�㰴����Դ���������֣�
        //TextureImporter
        //���ڵ���������Դ�������������ѹ����ʽ���ߴ硢ƽ�̷�ʽ������
        //API˵����
        //https://docs.unity3d.com/ScriptReference/TextureImporter.html

        //ModelImporter
        //���ڵ���ģ����Դ��������ģ�͵ĵ������ã������񡢲��ʡ�������
        //API˵����
        //https://docs.unity3d.com/ScriptReference/ModelImporter.html

        //AudioImporter
        //���ڵ�����Ƶ��Դ����������Ƶ�ĵ������ã���ѹ����ʽ����Ƶ������
        //API˵����
        //https://docs.unity3d.com/ScriptReference/AudioImporter.html

        //VideoClipImporter
        //���ڵ�����Ƶ��Դ����������Ƶ�ĵ������ã�����Ƶ������ѭ��ģʽ��
        //API˵����
        //https://docs.unity3d.com/ScriptReference/VideoClipImporter.html

        //ScriptedImporter
        //���ڴ����Զ������Դ������������ͨ����д�ű���ʵ�ֶ��ض�������Դ�ĵ������úʹ����߼�
        //�����Ҫ��ĳЩ�ض���ʽ����Դ�����Զ������ô�������ͨ���̳и���ķ�ʽȥʵ��
        //API˵����
        //https://docs.unity3d.com/ScriptReference/AssetImporters.ScriptedImporter.html
        #endregion
    }
}
