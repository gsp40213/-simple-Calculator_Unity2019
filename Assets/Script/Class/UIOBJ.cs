using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class UIOBJ
{
    public abstract class ButtonSetting
    {
        protected Button button;
        protected float pointX, pointY, sizeX, sizeY;
        protected UnityAction onClick;

        public ButtonSetting(Button button, float pointX, float pointY, float sizeX, float sizeY, UnityAction onClick)
        {
            this.button = button;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.onClick = onClick;
        }

        public abstract Button function(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor,
           Color color, int textSize);
    }

    public abstract class Image_Setting
    {
        protected Image image;
        protected float pointX, pointY, sizeX, sizeY;

        public Image_Setting(Image image, float pointX, float pointY, float sizeX, float sizeY)
        {
            this.image = image;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public abstract Image function(Sprite sprite);
        public abstract Image function(Sprite sprite, bool horizontal, bool vertical, RectTransform content);
    }

    public abstract class Text_Setting
    {
        protected Text text;
        protected float pointX, pointY, sizeX, sizeY;

        public Text_Setting(Text text, float pointX, float pointY, float sizeX, float sizeY)
        {

            this.text = text;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public Text_Setting(Text text, float sizeX, float sizeY)
        {
            this.text = text;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public abstract Text function(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor,
            Color color, int textSize);

        public abstract Text function(int fontsize, string message, Vector2 anchorsMin, Vector2 anchorsMax,
            Vector2 pivot);
    }

    public abstract class InputField_Setting
    {
        protected InputField inputField;
        protected float pointX, pointY, sizeX, sizeY;

        public InputField_Setting(InputField inputField, float pointX, float pointY, float sizeX, float sizeY)
        {
            this.inputField = inputField;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public abstract InputField function(Font font, FontStyle fontStyle, TextAnchor textAnchor, Color color,
            int textSize, InputField.ContentType contentType);
    }

    public abstract class Toggle_Setting
    {
        protected Toggle toggle;
        protected Sprite breakGourd;
        protected float pointX, pointY;

        public Toggle_Setting(Toggle toggle, Sprite breakGourd, float pointX, float pointY)
        {
            this.toggle = toggle;
            this.breakGourd = breakGourd;
            this.pointX = pointX;
            this.pointY = pointY;
        }

        public abstract Toggle function(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor,
           Color color, int textSize);
    }

    public abstract class Area_Setting
    {
        protected RectTransform areaObj;
        protected Vector2 anchorsMin;
        protected Vector2 anchorsMax;
        protected Vector2 pivot;

        public Area_Setting(RectTransform areaObj, Vector2 anchorsMin, Vector2 anchorsMax, Vector2 pivot)
        {
            this.areaObj = areaObj;
            this.anchorsMin = anchorsMin;
            this.anchorsMax = anchorsMax;
            this.pivot = pivot;
        }

        public abstract RectTransform function(TextAnchor textAnchor, bool controlWidth, bool controlHeight,
            bool scaleWidth, bool scaleHeight, bool forceExpandWidth, bool forceExpandHeight);

        public abstract RectTransform defaultFunction(Vector2 sizeDelta);
    }
}

public interface OnClick
{
    void onClick();
}

public interface CalculatoOnClck
{
    void oneClick();
    void twoClick();
    void threeClick();
    void addClick();
    void fourClick();
    void fiveClick();
    void sixClick();
    void reduceClick();
    void sevenClick();
    void eightClick();
    void nineClick();
    void takeClick();
    void zeroClick();
    void chearClick();
    void equalClick();
    void removeClick();
}