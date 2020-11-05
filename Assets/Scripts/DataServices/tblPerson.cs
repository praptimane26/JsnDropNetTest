using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SQLite4Unity3d;
using System;


[Serializable]
public class tblPerson
{
    [PrimaryKey]
    public string PersonID { get; set; }
    public int HighScore { get; set; }
    public string Password { get; set; }
 }
