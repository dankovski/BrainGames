using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockGameController : MonoBehaviour
{

    [SerializeField]
    private Block PrefabBlock;
    [SerializeField]
    private GameObject winWindow;
    [SerializeField]
    private GameObject buttons;

    private Block[] blocks;
    private int emptyBlockNumber = 4;
    private bool isWin = false;

    void Start()
    {
        blocks = new Block[9];

        blocks[0] = Instantiate(PrefabBlock, new Vector3(-300, 600, 5), Quaternion.identity);
        blocks[1] = Instantiate(PrefabBlock, new Vector3(0, 600, 5), Quaternion.identity);
        blocks[2] = Instantiate(PrefabBlock, new Vector3(300, 600, 5), Quaternion.identity);
        blocks[3] = Instantiate(PrefabBlock, new Vector3(-300, 300, 5), Quaternion.identity);
        blocks[4] = Instantiate(PrefabBlock, new Vector3(0, 300, 5), Quaternion.identity);
        blocks[5] = Instantiate(PrefabBlock, new Vector3(300, 300, 5), Quaternion.identity);
        blocks[6] = Instantiate(PrefabBlock, new Vector3(-300, 0, 5), Quaternion.identity);
        blocks[7] = Instantiate(PrefabBlock, new Vector3(0, 0, 5), Quaternion.identity);
        blocks[8] = Instantiate(PrefabBlock, new Vector3(300, 0, 5), Quaternion.identity);

        for(int i = 0; i < 9; i++)
        {
            blocks[i].setFieldNumber(i);
        }

        gameRestart();
    }

    public void updateGame(int mClickedNumber)
    {
        if (blocks[mClickedNumber].canMove() && !isWin)
        {
            blocks[emptyBlockNumber].changeNumber(blocks[mClickedNumber].getNumber());
            emptyBlockNumber = mClickedNumber;
            checkMoves();
            checkWin();
        }
    }

    void checkMoves()
    {

        for (int i = 0; i < 9; i++)
        {
            blocks[i].setMoveAbility(false);
        }

        switch (emptyBlockNumber)
        {
            case 0:
                blocks[1].setMoveAbility(true);
                blocks[3].setMoveAbility(true);
                break;
            case 1:
                blocks[0].setMoveAbility(true);
                blocks[2].setMoveAbility(true);
                blocks[4].setMoveAbility(true);
                break;
            case 2:
                blocks[1].setMoveAbility(true);
                blocks[5].setMoveAbility(true);
                break;
            case 3:
                blocks[0].setMoveAbility(true);
                blocks[6].setMoveAbility(true);
                blocks[4].setMoveAbility(true);
                break;
            case 4:
                blocks[1].setMoveAbility(true);
                blocks[3].setMoveAbility(true);
                blocks[5].setMoveAbility(true);
                blocks[7].setMoveAbility(true);
                break;
            case 5:
                blocks[2].setMoveAbility(true);
                blocks[4].setMoveAbility(true);
                blocks[8].setMoveAbility(true);
                break;
            case 6:
                blocks[7].setMoveAbility(true);
                blocks[3].setMoveAbility(true);
                break;
            case 7:
                blocks[6].setMoveAbility(true);
                blocks[8].setMoveAbility(true);
                blocks[4].setMoveAbility(true);
                break;
            case 8:
                blocks[5].setMoveAbility(true);
                blocks[7].setMoveAbility(true);
                break;
        }

        blocks[emptyBlockNumber].clearNumber();

    }

    public void gameRestart()
    {
        isWin = false;
        emptyBlockNumber = 4;
        buttons.SetActive(true);
        winWindow.SetActive(false);

        blocks[emptyBlockNumber].clearNumber();
        
        List<int> numbersArray = new List<int>();

        for (int i = 0; i < 8; i++) {
            numbersArray.Add(i + 1);
        }

        for (int index = 0; index < 9; index++) {
            if (index != emptyBlockNumber)
            {
                int chosen = Random.Range(0, numbersArray.Count);
                blocks[index].changeNumber(numbersArray[chosen]);
                numbersArray.RemoveAt(chosen);
            }
        }

        checkMoves();

    }

    void checkWin()
    {
        int counter=0;

        for(int i = 0; i < 9; i++)
        {
            if((blocks[i].getNumber()-1)== blocks[i].getFieldNumber())
            {
                counter++;
            }
        }

        if (counter == 9)
        {
            buttons.SetActive(false);
            winWindow.SetActive(true);
            isWin = true;
        }
    }

}
