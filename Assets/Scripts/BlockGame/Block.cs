using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Block : MonoBehaviour
{
    [SerializeField]
    private GameObject blockBackground;
   
    [SerializeField]
    private BoxCollider2D boxCollider;

    [SerializeField]
    private Text textNumber;

    private GameObject controllerObject;
    private int number=0;
    private int fieldNumber = 0;

    [SerializeField]
    private colors blockColor;
    [System.Serializable]
    public class colors
    { 
        public Color colorSelected;
        public Color colorMovable;
        public Color colorBasic;
    }
    
    private bool canBlockMove = false;
    private SpriteRenderer spriteRenderer;
    private BlockGameController gameControllerScript;

    private void Awake()
    {
        spriteRenderer = blockBackground.GetComponent<SpriteRenderer>();
        controllerObject = GameObject.FindWithTag("controller1");
        gameControllerScript = controllerObject.GetComponent<BlockGameController>();
        spriteRenderer.color = blockColor.colorBasic;
    }

    public bool canMove()
    {
        return canBlockMove;
    }

    public void setMoveAbility(bool mCanMove)
    {
        canBlockMove = mCanMove;
        if (mCanMove)
        {
            spriteRenderer.color = blockColor.colorMovable;
        }
        else {
            spriteRenderer.color = blockColor.colorBasic;
        }

    }

    private void OnMouseDown()
    {
        gameControllerScript.updateGame(fieldNumber);
    }

    public void clearNumber()
    {
        number = 9;
        textNumber.text = "";
        canBlockMove = false;
        spriteRenderer.color = blockColor.colorSelected;
    }

    public void changeNumber(int mNewNumber)
    {
        number = mNewNumber;
        textNumber.text = number.ToString();
        spriteRenderer.color = blockColor.colorBasic;
    }

    public int getNumber()
    {
        return number;
    }

    public void setFieldNumber(int mFieldNumber)
    {
        fieldNumber = mFieldNumber;
    }

    public int getFieldNumber()
    {
        return fieldNumber;
    }

}
