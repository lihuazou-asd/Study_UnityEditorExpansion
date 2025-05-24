using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson43 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 AssetDatabase中的常用API
        //1.创建资源,我们可以通过代码动态创建一些资源
        //  路径从 Assets/...开始
        //  AssetDatabase.CreateAsset(资源,路径);
        //  注意：
        //  不能在StreamingAssets中创建资源，
        //  不能创建预设体（预设体创建之后会讲），
        //  只能创建资源相关，例如材质球等
        //  路径需要写后缀

        //2.创建文件夹，路径从 Assets/...开始
        //  AssetDatabase.CreateFolder(父文件夹，新文件夹名)

        //3.拷贝资源，路径从 Assets/...开始
        //  AssetDatabase.CopyAsset(源资源，目标路径)
        //  注意：
        //  需要写后缀名

        //4.移动资源，路径从 Assets/...开始
        //  AssetDatabase.MoveAsset(老路径, 新路径);

        //5.删除资源，路径从 Assets/...开始
        //  AssetDatabase.DeleteAsset(资源路径)

        //6.批量删除资源，路径从 Assets/...开始
        //  AssetDatabase.DeleteAssets(string[] 路径们, List<string> 用于存储删除失败的路径)

        //7.获取资源路径 可以配合Selection选中资源一起使用
        //  AssetDatabase.GetAssetPath(资源)

        //8.根据路径加载资源，路径从Assets/开始
        //  AssetDatabase.LoadAssetAtPath(资源路径)

        //9.根据路径加载所有资源，路径从Assets/开始
        //  AssetDatabase.LoadAllAssetsAtPath(资源路径);
        //  一般可以用来加载图集资源，返回值为Object数据
        //  如果是图集，第一个为图集本身，之后的便是图集中的所有Sprite

        //10.刷新，当对资源进行移动、导入、删除等操作后，需要执行刷新
        //  AssetDatabase.Refresh()

        //11.返回资源所属的AB包名，路径从Assets/开始
        //  GetImplicitAssetBundleName（资源路径);
        #endregion

        #region 知识点二 更多内容
        //https://docs.unity3d.com/ScriptReference/AssetDatabase.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
