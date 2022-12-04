﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace karrtavaya
{
    internal class Controller
    {
        public static List<Good> Goods = new List<Good>();
        public void AddGood(string title,float price,float sale)
        {
            Good good = new Good()
            {
                Title = title,
                Price = price,
                Sale = sale,
            };
            Goods.Add(good);
        }
        public string GetGoods()
        {
            string text = "";
            foreach (var item in Goods)
            {
                text +=$"{item.Title} цена - {item.Price}\n";
            }
            return text;
        }
        public void SaveList()
        {
            var json = JsonSerializer.Serialize<List<Good>>(Goods);
            File.WriteAllText("db.json", json);
        }
        public void OpenList()
        {
            if (!File.Exists("db,json"))
                return;
            var json = File.ReadAllText("db.json");
            Goods = JsonSerializer.Deserialize<List<Good>>(json);
        }
        public void Delete()
        {
            string t = Console.ReadLine();
            var x = Goods.FirstOrDefault(x => x.Title == t);
            if (x == null)
                return;
            Goods.Remove(x);
        }
    }

}
