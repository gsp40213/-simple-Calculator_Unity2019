using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ConversionInterface
{

    private Button button1, button2, button3, button4;
    ButtonSetting button1Setting, button2Setting, button3Setting, button4Setting;

    private Text calculatorInputDisplay;
    TextSetting calculatorbtnSetting;

    public ConversionInterface(Button button1, Button button2, Button button3, Button button4)
    {
        this.button1 = button1;
        this.button2 = button2;
        this.button3 = button3;
        this.button4 = button4;
    }

    public void calculatorHorizontalBtns(float pointY, Font font, string btnStr1, string btnStr2, string btnStr3, string btnStr4,
        UnityAction unityAction1, UnityAction unityAction2, UnityAction unityAction3, UnityAction unityAction4)
    {
        button1Setting = new ButtonSetting(button1, 0.4f, 0.7f + pointY, 0.3f, 0.15f, unityAction1);
        button1Setting.function(font, FontStyle.Normal, btnStr1, TextAnchor.MiddleCenter, Color.black, 7);

        button2Setting = new ButtonSetting(button2, 0.8f, 0.7f + pointY, 0.3f, 0.15f, unityAction2);
        button2Setting.function(font, FontStyle.Normal, btnStr2, TextAnchor.MiddleCenter, Color.black, 7);

        button3Setting = new ButtonSetting(button3, 1.2f, 0.7f + pointY, 0.3f, 0.15f, unityAction3);
        button3Setting.function(font, FontStyle.Normal, btnStr3, TextAnchor.MiddleCenter, Color.black, 7);

        button4Setting = new ButtonSetting(button4, 1.6f, 0.7f + pointY, 0.3f, 0.15f, unityAction4);
        button4Setting.function(font, FontStyle.Normal, btnStr4, TextAnchor.MiddleCenter, Color.black, 7);
    }
}
