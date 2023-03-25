using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    private int _id;
    public int ID {get {return _id;} set { _id = value;} }

    private int _charSkinId;
    public int CharSkinId {get {return _charSkinId;} set { _charSkinId = value;} }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;

    public void InnitCharID(int id)
    {
        _id = id;
        _charSkinId = Random.Range (0,charSkin.Length - 1);
        staffName = "xxx";
        dailyWage = Random.Range(90, 125);
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == _charSkinId)
            {
                charSkin[i].SetActive(true);
                
            }
            else charSkin[i].SetActive(false);
        }
    }


}

