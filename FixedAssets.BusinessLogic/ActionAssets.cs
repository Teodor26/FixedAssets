﻿using FixedAssets.BusinessLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.BusinessLogic
{
    public enum Items
    {
        Computer = 1,
        Furniture,
        Officeitems,
        HouseholdItem
    }
    public class ActionAssets : BaseForAsset
    {

        BaseForAsset[] assets = new BaseForAsset[4];

        Dictionary<int, Action> actionList = new Dictionary<int, Action>();

        public delegate void Message(string mes);
        Message _mes;

        public void Register(Message mes)
        {
            _mes = mes;
        }
        public ActionAssets()
        {
            assets[0] = new Computer();
            assets[1] = new Furniture();
            assets[2] = new Officeitems();
            assets[3] = new HouseHoldItem();

            actionList.Add((int)Items.Computer, assets[0].methodList);
            actionList.Add((int)Items.Furniture, assets[1].methodList);
            actionList.Add((int)Items.HouseholdItem, assets[2].methodList);
            actionList.Add((int)Items.Officeitems, assets[3].methodList);                 
        }

        public void ShowName()
        {
            int j = 1;
            foreach(var c in assets)
            {
                Console.WriteLine("{0}.{1}",j++,c.Name);
            }
        }

        public void GetList()
        {

            foreach (var c in dictionary)
            {
                Console.WriteLine("{0} {1} days", c.Name, c.Expiration);
            }
        }

        public void Choise(int Opt)
        {
            if (actionList.ContainsKey(Opt))
            {
                actionList[Opt]();
            }
            else
                _mes("That is wrong number. Input correct number");
            
        }
        
        public void ShowList()
        {
            foreach(var c in dictionary)
            {
                Console.WriteLine("{0} {1}",c.Name, c.Expiration);
            }
        }       

    }
}
