using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ButtonCodes
{
    buttonOne = 0b00001,
    buttonTwo = 0b00010,
    buttonThree = 0b00100,
    buttonFour = 0b01000,
    buttonFive = 0b10000
}

public class CustomController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("---->" + TCPServer.inputValue);
    }

    public static float Gethorizontal()
    {
        int value = 0;

        if((int)ButtonCodes.buttonOne == (TCPServer.inputValue & (int)ButtonCodes.buttonOne))
        {
            value += 1;
        }
        if ((int)ButtonCodes.buttonTwo == (TCPServer.inputValue & (int)ButtonCodes.buttonTwo))
        {
            value -= 1;
        }
        return value;
    }

    public static float Getvertical()
    {
        int value = 0;
        Debug.Log("jotakin " + TCPServer.inputValue);
        if ((int)ButtonCodes.buttonThree == (TCPServer.inputValue & (int)ButtonCodes.buttonThree))
        {
            value += 1;
        }
        if ((int)ButtonCodes.buttonFour == (TCPServer.inputValue & (int)ButtonCodes.buttonFour))
        {
            value -= 1;
        }
        return value;
    }

    public static float ButtonStart()
    {
        int value = 0;
        if ((int)ButtonCodes.buttonOne == (TCPServer.inputValue & (int)ButtonCodes.buttonOne))
        {
            value += 1;
        }
        if ((int)ButtonCodes.buttonTwo == (TCPServer.inputValue & (int)ButtonCodes.buttonTwo))
        {
            value -= 1;
        }
        Debug.Log("jotakin " + TCPServer.inputValue);
        if ((int)ButtonCodes.buttonFive == (TCPServer.inputValue & (int)ButtonCodes.buttonFive))
        {
            value = 1;
        }
        
        return value;
    }
    public static float ButtonQuit()
    {
        int value = 0;
        if ((int)ButtonCodes.buttonOne == (TCPServer.inputValue & (int)ButtonCodes.buttonOne))
        {
            value += 1;
        }
        if ((int)ButtonCodes.buttonTwo == (TCPServer.inputValue & (int)ButtonCodes.buttonTwo))
        {
            value -= 1;
        }
        Debug.Log("Menu2 jotakin " + TCPServer.inputValue);
        if ((int)ButtonCodes.buttonFive == (TCPServer.inputValue & (int)ButtonCodes.buttonFive))
        {
            value = 1;
        }

        return value;
    }

    public static float QuitToMenu()
    {
        int value = 0;
        if ((int)ButtonCodes.buttonOne == (TCPServer.inputValue & (int)ButtonCodes.buttonOne))
        {
            value += 1;
        }
        if ((int)ButtonCodes.buttonTwo == (TCPServer.inputValue & (int)ButtonCodes.buttonTwo))
        {
            value -= 1;
        }
        Debug.Log("Menu jotakin " + TCPServer.inputValue);
        if ((int)ButtonCodes.buttonFive == (TCPServer.inputValue & (int)ButtonCodes.buttonFive))
        {
            value = 1;
        }

        return value;
    }
}
