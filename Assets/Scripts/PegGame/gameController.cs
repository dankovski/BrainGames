using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField]
    private Checker checkerPrefab;

    private Checker[] checkers;
    private int selectedIndex = 0;
    private bool isSelected= false;
    private int startPosition = 0;
    private int moves = 0;

    public GameObject winWindow;
    public GameObject lossWindow;
    public GameObject buttons;

    void Start()
    {
        checkers = new Checker[15];
        checkers[0] = Instantiate(checkerPrefab, new Vector3(0, 500, 0), Quaternion.identity);
        checkers[1] = Instantiate(checkerPrefab, new Vector3(-80, 300, 0), Quaternion.identity);
        checkers[2] = Instantiate(checkerPrefab, new Vector3(80, 300, 0), Quaternion.identity);
        checkers[3] = Instantiate(checkerPrefab, new Vector3(-160, 100, 0), Quaternion.identity);
        checkers[4] = Instantiate(checkerPrefab, new Vector3(0, 100, 0), Quaternion.identity);
        checkers[5] = Instantiate(checkerPrefab, new Vector3(160, 100,0), Quaternion.identity);
        checkers[6] = Instantiate(checkerPrefab, new Vector3(-240, -100, 0), Quaternion.identity);
        checkers[7] = Instantiate(checkerPrefab, new Vector3(-80, -100, 0), Quaternion.identity);
        checkers[8] = Instantiate(checkerPrefab, new Vector3(80, -100, 0), Quaternion.identity);
        checkers[9] = Instantiate(checkerPrefab, new Vector3(240, -100, 0), Quaternion.identity);
        checkers[10] = Instantiate(checkerPrefab, new Vector3(-320, -300, 0), Quaternion.identity);
        checkers[11] = Instantiate(checkerPrefab, new Vector3(-160, -300, 0), Quaternion.identity);
        checkers[12] = Instantiate(checkerPrefab, new Vector3(0, -300, 0), Quaternion.identity);
        checkers[13] = Instantiate(checkerPrefab, new Vector3(160, -300, 0), Quaternion.identity);
        checkers[14] = Instantiate(checkerPrefab, new Vector3(320, -300, 0), Quaternion.identity);

        for(int i = 0; i < 15; i++)
        {
            checkers[i].changeNumber(i); 
            checkers[i].setBasic();
        }
        checkers[startPosition].setEmpty();
        
    }

    void loseGame()
    { 
        lossWindow.SetActive(true);
        buttons.SetActive(false);
    }

    void winGame()
    {
        buttons.SetActive(false);
        winWindow.SetActive(true);
    }

    public void resetGame()
    {

        for (int i = 0; i < 15; i++)
        {
            checkers[i].changeNumber(i);
            checkers[i].setBasic();
        }

        checkers[startPosition].setEmpty();
        isSelected = false;
        moves = 0;
    }

    void checkMoves()
    {
        switch (selectedIndex)
        {
            case 0:
                if (!checkers[1].isEmpty() && checkers[3].isEmpty())
                {
                    checkers[3].setMovable();
                }
                if (!checkers[2].isEmpty() && checkers[5].isEmpty())
                {
                    checkers[5].setMovable();
                }
                break;
            case 1:
                if (!checkers[3].isEmpty() && checkers[6].isEmpty())
                {
                    checkers[6].setMovable();
                }
                if (!checkers[4].isEmpty() && checkers[8].isEmpty())
                {
                    checkers[8].setMovable();
                }
                break;
            case 2:
                if (!checkers[4].isEmpty() && checkers[7].isEmpty())
                {
                    checkers[7].setMovable();
                }
                if (!checkers[5].isEmpty() && checkers[9].isEmpty())
                {
                    checkers[9].setMovable();
                }
                break;
            case 3:
                if (!checkers[6].isEmpty() && checkers[10].isEmpty())
                {
                    checkers[10].setMovable();
                }
                if (!checkers[7].isEmpty() && checkers[12].isEmpty())
                {
                    checkers[12].setMovable();
                }
                if (!checkers[4].isEmpty() && checkers[5].isEmpty())
                {
                    checkers[5].setMovable();
                }
                if (!checkers[1].isEmpty() && checkers[0].isEmpty())
                {
                    checkers[0].setMovable();
                }
                break;
            case 4:
                if (!checkers[7].isEmpty() && checkers[11].isEmpty())
                {
                    checkers[11].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[13].isEmpty())
                {
                    checkers[13].setMovable();
                }
                break;
            case 5:
                if (!checkers[2].isEmpty() && checkers[0].isEmpty())
                {
                    checkers[0].setMovable();
                }
                if (!checkers[4].isEmpty() && checkers[3].isEmpty())
                {
                    checkers[3].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[12].isEmpty())
                {
                    checkers[12].setMovable();
                }
                if (!checkers[9].isEmpty() && checkers[14].isEmpty())
                {
                    checkers[14].setMovable();
                }
                break;
            case 6:
                if (!checkers[7].isEmpty() && checkers[8].isEmpty())
                {
                    checkers[8].setMovable();
                }
                if (!checkers[3].isEmpty() && checkers[1].isEmpty())
                {
                    checkers[1].setMovable();
                }
                break;
            case 7:
                if (!checkers[4].isEmpty() && checkers[2].isEmpty())
                {
                    checkers[2].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[9].isEmpty())
                {
                    checkers[9].setMovable();
                }
                break;
            case 8:
                if (!checkers[4].isEmpty() && checkers[1].isEmpty())
                {
                    checkers[1].setMovable();
                }
                if (!checkers[7].isEmpty() && checkers[6].isEmpty())
                {
                    checkers[6].setMovable();
                }
                break;
            case 9:
                if (!checkers[5].isEmpty() && checkers[2].isEmpty())
                {
                    checkers[2].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[7].isEmpty())
                {
                    checkers[7].setMovable();
                }
                break;
            case 10:
                if (!checkers[6].isEmpty() && checkers[3].isEmpty())
                {
                    checkers[3].setMovable();
                }
                if (!checkers[11].isEmpty() && checkers[12].isEmpty())
                {
                    checkers[12].setMovable();
                }
                break;
            case 11:
                if (!checkers[7].isEmpty() && checkers[4].isEmpty())
                {
                    checkers[4].setMovable();
                }
                if (!checkers[12].isEmpty() && checkers[13].isEmpty())
                {
                    checkers[13].setMovable();
                }
                break;
            case 12:
                if (!checkers[11].isEmpty() && checkers[10].isEmpty())
                {
                    checkers[10].setMovable();
                }
                if (!checkers[7].isEmpty() && checkers[3].isEmpty())
                {
                    checkers[3].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[5].isEmpty())
                {
                    checkers[5].setMovable();
                }
                if (!checkers[13].isEmpty() && checkers[14].isEmpty())
                {
                    checkers[14].setMovable();
                }
                break;
            case 13:
                if (!checkers[12].isEmpty() && checkers[11].isEmpty())
                {
                    checkers[11].setMovable();
                }
                if (!checkers[8].isEmpty() && checkers[4].isEmpty())
                {
                    checkers[4].setMovable();
                }
                break;
            case 14:
                if (!checkers[9].isEmpty() && checkers[5].isEmpty())
                {
                    checkers[5].setMovable();
                }
                if (!checkers[13].isEmpty() && checkers[12].isEmpty())
                {
                    checkers[12].setMovable();
                }
                break;

        }
    }

    bool isMovePossible() {

        if ((!checkers[0].isEmpty() && ((!checkers[1].isEmpty() && checkers[3].isEmpty()) || (!checkers[2].isEmpty() && checkers[5].isEmpty()))) ||
            (!checkers[1].isEmpty() && ((!checkers[3].isEmpty() && checkers[6].isEmpty()) || (!checkers[4].isEmpty() && checkers[8].isEmpty()))) ||
            (!checkers[2].isEmpty() && ((!checkers[4].isEmpty() && checkers[7].isEmpty()) || (!checkers[5].isEmpty() && checkers[9].isEmpty()))) ||
            (!checkers[3].isEmpty() && ((!checkers[6].isEmpty() && checkers[10].isEmpty()) || (!checkers[7].isEmpty() && checkers[12].isEmpty()) ||
            (!checkers[4].isEmpty() && checkers[5].isEmpty()) || (!checkers[1].isEmpty() && checkers[0].isEmpty()))) ||
            (!checkers[4].isEmpty() && ((!checkers[7].isEmpty() && checkers[11].isEmpty()) || (!checkers[8].isEmpty() && checkers[13].isEmpty()))) ||
            (!checkers[5].isEmpty() && ((!checkers[2].isEmpty() && checkers[0].isEmpty()) || (!checkers[4].isEmpty() && checkers[3].isEmpty()) || 
            (!checkers[8].isEmpty() && checkers[12].isEmpty()) || (!checkers[9].isEmpty() && checkers[14].isEmpty()))) ||
            (!checkers[6].isEmpty() && ((!checkers[7].isEmpty() && checkers[8].isEmpty()) || (!checkers[3].isEmpty() && checkers[1].isEmpty()))) ||
            (!checkers[7].isEmpty() && ((!checkers[4].isEmpty() && checkers[2].isEmpty()) || (!checkers[8].isEmpty() && checkers[9].isEmpty()))) ||
            (!checkers[8].isEmpty() && ((!checkers[4].isEmpty() && checkers[1].isEmpty()) || (!checkers[7].isEmpty() && checkers[6].isEmpty()))) ||
            (!checkers[9].isEmpty() && ((!checkers[5].isEmpty() && checkers[2].isEmpty()) || (!checkers[8].isEmpty() && checkers[7].isEmpty()))) ||
            (!checkers[10].isEmpty() && ((!checkers[6].isEmpty() && checkers[3].isEmpty()) || (!checkers[11].isEmpty() && checkers[12].isEmpty()))) ||
            (!checkers[11].isEmpty() && ((!checkers[7].isEmpty() && checkers[4].isEmpty()) || (!checkers[12].isEmpty() && checkers[13].isEmpty()))) ||
            (!checkers[12].isEmpty() && ((!checkers[11].isEmpty() && checkers[10].isEmpty()) || (!checkers[7].isEmpty() && checkers[3].isEmpty()) ||
            (!checkers[8].isEmpty() && checkers[5].isEmpty()) || (!checkers[13].isEmpty() && checkers[14].isEmpty()))) ||
            (!checkers[13].isEmpty() && ((!checkers[12].isEmpty() && checkers[11].isEmpty()) || (!checkers[8].isEmpty() && checkers[4].isEmpty()))) ||
            (!checkers[14].isEmpty() && ((!checkers[9].isEmpty() && checkers[5].isEmpty()) || (!checkers[13].isEmpty() && checkers[12].isEmpty()))))
        {
            return true;
        }
        else 
        {
            return false;
        }

    }

    void resetMoves()
    {
        for (int i = 0; i < 15; i++)
        {
            if (checkers[i].canMove())
            {
                checkers[i].setEmpty();
            }
        }
    }

    public void updateClick(int mNumber)
    {
        //unselecting selected checker
        if(isSelected && mNumber == selectedIndex)
        {
            checkers[mNumber].setBasic();
            isSelected = false;
            resetMoves();
        }
        //change selected checker
        else if (!checkers[mNumber].isEmpty() && !checkers[mNumber].canMove() && mNumber != selectedIndex && isSelected)
        {
            resetMoves();
            checkers[mNumber].setSelected();
            checkers[selectedIndex].setBasic();
            selectedIndex = mNumber;
            checkMoves();
        }
        //selecting checker
        else if(!checkers[mNumber].isEmpty() && !checkers[mNumber].canMove()  && !isSelected)
        {
            checkers[mNumber].setSelected();
            selectedIndex = mNumber;
            isSelected = true;
            checkMoves();
        }
        //making a move
        else if (isSelected && checkers[mNumber].canMove()) 
        {
            checkers[mNumber].setBasic();
            checkers[selectedIndex].setEmpty();

            if ((mNumber == 3 && selectedIndex == 0) || (mNumber == 0 && selectedIndex == 3))
            {
                checkers[1].setEmpty();
            }
            else if ((mNumber == 0 && selectedIndex == 5) || (mNumber == 5 && selectedIndex == 0))
            {
                checkers[2].setEmpty();
            }
            else if ((mNumber == 1 && selectedIndex == 6) || (mNumber == 6 && selectedIndex == 1))
            {
                checkers[3].setEmpty();
            }
            else if ((mNumber == 2 && selectedIndex == 7) || (mNumber == 7 && selectedIndex == 2) || (mNumber == 1 && selectedIndex == 8) ||
                (mNumber == 8 && selectedIndex == 1) || (mNumber == 3 && selectedIndex == 5) || (mNumber == 5 && selectedIndex == 3))
            {
                checkers[4].setEmpty();
            }
            else if ((mNumber == 2 && selectedIndex == 9) || (mNumber == 9 && selectedIndex == 2))
            {
                checkers[5].setEmpty();
            }
            else if ((mNumber == 3 && selectedIndex == 10) || (mNumber == 10 && selectedIndex == 3))
            {
                checkers[6].setEmpty();
            }
            else if ((mNumber == 4 && selectedIndex == 11) || (mNumber == 11 && selectedIndex == 4) || (mNumber == 3 && selectedIndex == 12) ||
                (mNumber == 12 && selectedIndex == 3) || (mNumber == 8 && selectedIndex == 6) || (mNumber == 6 && selectedIndex == 8))
            {
                checkers[7].setEmpty();
            }
            else if ((mNumber == 5 && selectedIndex == 12) || (mNumber == 12 && selectedIndex == 5) || (mNumber == 4 && selectedIndex == 13) ||
                (mNumber == 13 && selectedIndex == 4) || (mNumber == 7 && selectedIndex == 9) || (mNumber == 9 && selectedIndex == 7))
            {
                checkers[8].setEmpty();
            }
            else if ((mNumber == 5 && selectedIndex == 14) || (mNumber == 14 && selectedIndex == 5))
            {
                checkers[9].setEmpty();
            }
            else if ((mNumber == 10 && selectedIndex == 12) || (mNumber == 12 && selectedIndex == 10))
            {
                checkers[11].setEmpty();
            }
            else if ((mNumber == 11 && selectedIndex == 13) || (mNumber == 13 && selectedIndex == 11))
            {
                checkers[12].setEmpty();
            }
            else if ((mNumber == 12 && selectedIndex == 14) || (mNumber == 14 && selectedIndex == 12))
            {
                checkers[13].setEmpty();
            }

            moves++;
            isSelected = false;
            selectedIndex = mNumber;
            resetMoves();

            if (moves == 13)
            {
                winGame();
            }
            else if (!isMovePossible())
            {
                loseGame();
            }
        }
    }
}
