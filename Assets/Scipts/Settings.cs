﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    protected double Maxvalue_x;
    protected double Maxvalue_y;
    public static string X_name;
    public static string Y_name;
    public static string Z_name;
    public static bool player_active;
    protected double Maxvalue_z;
    protected string CSV_address;
    public GameObject fireware;
    public GameObject stat_text;
    // Start is called before the first frame update
    void Start()
    {
        fireware = GameObject.Find("Fireware_Pnl");
        stat_text = GameObject.Find("Stat_txt");
        stat_text.GetComponent<Text>().text = "wewo";
        fireware.SetActive(false);
        player_active = true;   

    }
    public void setaddress(string a)
    {
        CSV_address = a;
    }
    public void setfirewarepanel(bool a)
    {
        fireware.SetActive(a);
    }
    public string getaddress()
    {
        return CSV_address;
    }
    // Update is called once per frame
    void Update()
    {
        //if (!player_active)
        //{

            //Cursor.SetCursor();
        //}
    }
}