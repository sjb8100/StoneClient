﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroSelsectController : MonoBehaviour {

    public Image heroImg;
    public InputField groupName;


    private int zhiye;
    

    public void heroSelected(int index)
    {
        heroImg.sprite = Resources.Load<Sprite>("hero/hero" + (index+1).ToString());
        zhiye = index;
    }

    public void Load(string name,int index)
    {
        groupName.text = name;
        heroImg.sprite = Resources.Load<Sprite>("hero/hero" + (index + 1).ToString());
        zhiye = index;
    }

    public void Save()
    {
        Debug.LogFormat("保存 Name:{0},RolyType:{1}", groupName.text, zhiye);
        ShouCangManager.manager.SaveCardGroupInfo(groupName.text, zhiye);
    }
}
