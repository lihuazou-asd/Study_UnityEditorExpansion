using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson21 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson21/Event֪ʶ��ѧϰ")]
    private static void OpenLesson21()
    {
        Lesson21 win = EditorWindow.GetWindow<Lesson21>("Event֪ʶѧϰ");
        win.Show();
    }

    private void OnGUI()
    {
        //1.��ȡ��ǰ�¼�
        //  Event.current
        Event eve = Event.current;

        //2.alt���Ƿ���
        //  Event.current.alt
        if (eve.alt)
            Debug.Log("alt��������");

        //3.shift���Ƿ���
        //  Event.current.shift
        if (eve.shift)
            Debug.Log("shift��������");

        //4.ctrl���Ƿ���
        //  Event.current.control
        if (eve.control)
            Debug.Log("control��������");

        //5.�Ƿ�������¼�
        //  Event.current.isMouse
        if (eve.isMouse)
        {
            Debug.Log("�������¼�");
            //6.�ж���������Ҽ�
            //  Event.current.button (0,1,2 �ֱ���� ��,��,�� �������2������������갴��)
            Debug.Log(eve.button);
            //7.���λ��
            //  Event.current.mousePosition
            Debug.Log("���λ��" + eve.mousePosition);
        }

        //8.�ж��Ƿ��Ǽ�������
        //  Event.current.isKey
        if(eve.isKey)
        {
            Debug.Log("��������¼�");
            //9.��ȡ����������ַ�
            //  Event.current.character
            Debug.Log(eve.character);
            //10.��ȡ���������Ӧ��KeyCode
            //  Event.current.keyCode
            //Debug.Log(eve.keyCode);
            switch (eve.keyCode)
            {
                case KeyCode.Space:
                    Debug.Log("�ո������");
                    break;
            }
        }

        //11.�ж���������
        //  Event.current.type
        //  EventTypeö�ٺ����Ƚϼ���
        //  EventType���г��õ� ��갴��̧����ק�����̰���̧��ȵ�����
        //  һ�������� ���ж� ���� ���� ����̧������صĲ���

        //12.�Ƿ�������д ��Ӧ������caps���Ƿ���
        //  Event.current.capsLock
        if (eve.capsLock)
            Debug.Log("��Сд��������");
        else
            Debug.Log("��Сд�����ر�");

        //13.Windows����Command���Ƿ���
        //  Event.current.command
        if (eve.command)
            Debug.Log("PC win������ �� Mac Command������");

        //14.�����¼� �ַ���
        //  Event.current.commandName
        //  ���������ж��Ƿ񴥷��˶�Ӧ�ļ����¼�
        //  ����ֵ��
        //  Copy:����
        //  Paste:ճ��
        //  Cut:����
        if(eve.commandName == "Copy")
        {
            Debug.Log("������ctrl + c");
        }
        if (eve.commandName == "Paste")
        {
            Debug.Log("������ctrl + v");
        }
        if (eve.commandName == "Cut")
        {
            Debug.Log("������ctrl + x");
        }

        //15.������ƶ�����
        //  Event.current.delta

        //Debug.Log(eve.delta);

        //16.�Ƿ��ǹ��ܼ�����
        //  Event.current.functionKey
        //  ���ܼ�ָС�����е� �����, page up, page down, backspace�ȵ�
        if (eve.functionKey)
            Debug.Log("�й��ܰ�������");

        //17.С�����Ƿ���
        //  Event.current.numeric
        if(eve.numeric)
            Debug.Log("С�����Ƿ���");

        //18.������ϼ���ͻ
        //  Event.current.Use()
        //  �ڴ������Ӧ�����¼��󣬵��ø÷�����������ֹ�¼������ɷ������ú�Unity�����༭���¼��߼���ͻ
        eve.Use();
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ׼������
        //�Զ���һ���༭����չ��������Event֪ʶѧϰ
        #endregion

        #region ֪ʶ��һ Event��������������ʲô�ģ�
        //���ṩ��������Ժͷ�������������ʹ����û�����
        //��Ҫ������Unity�༭����չ������

        //��ΪInput���������Ҫ������ʱ���ܼ�������
        //��Eventר���ṩ���༭ģʽ��ʹ�ã����԰������Ǽ��������������¼���ز���
        //�� OnGUI �� OnSceneView �ж���ʹ��
        #endregion

        #region ֪ʶ��� ��ҪAPI
        //1.��ȡ��ǰ�����¼�
        //  Event.current

        //2.alt���Ƿ���
        //  Event.current.alt

        //3.shift���Ƿ���
        //  Event.current.shift

        //4.ctrl���Ƿ���
        //  Event.current.control

        //5.�Ƿ�������¼�
        //  Event.current.isMouse

        //6.�ж���������Ҽ�
        //  Evnet.current.button (0,1,2 �ֱ���� ��,��,�� �������2������������갴��)

        //7.���λ��
        //  Event.curretn.mousePosition

        //8.�ж��Ƿ��Ǽ�������
        //  Event.current.isKey

        //9.��ȡ����������ַ�
        //  Event.current.character

        //10.��ȡ���������Ӧ��KeyCode
        //  Event.current.keyCode

        //11.�ж���������
        //  Event.current.type
        //  EventTypeö�ٺ����Ƚϼ���
        //  EventType���г��õ� ��갴��̧����ק�����̰���̧��ȵ�����

        //12.�Ƿ�������д ��Ӧ������caps���Ƿ���
        //  Event.current.capsLock

        //13.Windows����Command���Ƿ���
        //  Event.current.command

        //14.�����¼� �ַ���
        //  Event.current.commandName
        //  ���������ж��Ƿ񴥷��˶�Ӧ�ļ����¼�
        //  ����ֵ��
        //  Copy:����
        //  Paste:ճ��
        //  Cut:����

        //15.������ƶ�����
        //  Event.current.delta

        //16.�Ƿ��ǹ��ܼ�����
        //  Event.current.functionKey
        //  ���ܼ�ָС�����е� �����, page up, page down, backspace�ȵ�

        //17.С�����Ƿ���
        //  Event.current.numeric

        //18.������ϼ���ͻ
        //  Event.current.Use()
        //  �ڴ������Ӧ�����¼��󣬵��ø÷�����������ֹ�¼������ɷ������ú�Unity�����༭���¼��߼���ͻ
        #endregion

        #region ֪ʶ���� ��������
        //https://docs.unity3d.com/ScriptReference/Event.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
