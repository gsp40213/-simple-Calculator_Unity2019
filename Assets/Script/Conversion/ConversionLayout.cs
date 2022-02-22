using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversionLayout : MonoBehaviour
{     
    public InputField calculationProcess_InputField, calculationResult_InputField;
    InputFieldSetting calculationProcess, calculationResult;

    public Button one_Button, two_Button, three_Button, add_Button;
    public Button four_Button, five_Button, six_Button, reduce_Button;
    public Button seven_Button, eight_Butotn, nine_Button, take_Button;
    public Button zero_Button, drop_Button, equal_Buttin, remove_Button;

    public Font textFont;

    ConversionInterface calculatoLayoutButtonHo1, calculatoLayoutButtonHo2, 
        calculatoLayoutButtonHo3, calculatoLayoutButtonHo4;

    public float pointX, pointY, sizeX, sizeY;

    // Start is called before the first frame update
    void Start()
    {  
        // 計算機按鈕
        calculatoLayoutButtonHo1 = new ConversionInterface(one_Button, two_Button, three_Button, add_Button);
        calculatoLayoutButtonHo1.calculatorHorizontalBtns(0.3f, textFont, "1", "2", "3", "+",
            new OnClickView().oneClick, new OnClickView().twoClick, new OnClickView().threeClick, new OnClickView().addClick);

        calculatoLayoutButtonHo2 = new ConversionInterface(four_Button, five_Button, six_Button, reduce_Button);
        calculatoLayoutButtonHo2.calculatorHorizontalBtns(0.1f, textFont, "4", "5", "6", "-",
            new OnClickView().fourClick, new OnClickView().fiveClick, new OnClickView().sixClick, new OnClickView().reduceClick);

        calculatoLayoutButtonHo3 = new ConversionInterface(seven_Button, eight_Butotn, nine_Button, take_Button);
        calculatoLayoutButtonHo3.calculatorHorizontalBtns(-0.1f, textFont, "7", "8", "9", "×",
            new OnClickView().sevenClick, new OnClickView().eightClick, new OnClickView().nineClick, new OnClickView().takeClick);

        calculatoLayoutButtonHo4 = new ConversionInterface(zero_Button, drop_Button, equal_Buttin, remove_Button);
        calculatoLayoutButtonHo4.calculatorHorizontalBtns(-0.3f, textFont, "0", "C", "=", "÷",
            new OnClickView().zeroClick, new OnClickView().chearClick, new OnClickView().equalClick, new OnClickView().removeClick);

        // 顯示計算過程
        calculationProcess = new InputFieldSetting(calculationProcess_InputField, 1, 1.56f, 1.6f, 0.2f);
        // 顯示計算結果
        calculationResult = new InputFieldSetting(calculationResult_InputField, 1, 1.3f, 1.6f, 0.2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        calculationProcess.function(textFont, FontStyle.Normal, TextAnchor.MiddleLeft, Color.black, 7, 
            InputField.ContentType.Standard);
        calculationProcess.setMessage(OnClickView.RESULT_PROCESS());

        calculationResult.function(textFont, FontStyle.Normal, TextAnchor.MiddleLeft, Color.black, 7,
            InputField.ContentType.Standard);
        calculationResult.setMessage(OnClickView.RESULT_());

    }
}
