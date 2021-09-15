using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class Checker : MonoBehaviour
{
    
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    
    private GameObject controllerObject;
    private int number;
    private bool empty = false;
    private bool canCheckerMove = false;
    private gameController gameControllerScript;

    [SerializeField]
    private colors selectColor;
    [System.Serializable]
    public class colors
    {
        public Color colorSelected;
        public Color colorMovable;
        public Color colorBasic;
        public Color colorEmpty;
    }

    public bool isEmpty()
    {
        return empty;
    }

    public bool canMove() {
        return canCheckerMove;
    }

    void Start()
    {
        controllerObject=GameObject.FindWithTag("GameController");
        gameControllerScript = controllerObject.GetComponent<gameController>();
    }

    public void changeNumber(int mNumber)
    {
        number = mNumber;
    }

    void OnMouseDown()
    {
        gameControllerScript.updateClick(number);
    }

    public void setSelected()
    {
        spriteRenderer.color= selectColor.colorSelected;
        empty = false;
        canCheckerMove = false;
}

    public void setMovable()
    {
        spriteRenderer.color = selectColor.colorMovable;
        canCheckerMove = true;
        empty = false;
    }

    public void setBasic()
    {
        empty = false;
        canCheckerMove = false;
        spriteRenderer.color = selectColor.colorBasic;
    }

    public void setEmpty()
    {
        spriteRenderer.color = selectColor.colorEmpty;
        empty = true;
        canCheckerMove = false;
    }

}
