using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using halisahaapp.entity;

namespace halisahaapp.webui.Helper
{
    public class DateHelper
    {

        private List<string> Times = new List<string>()
        {
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "12:00-13:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00",
            "17:00-18:00",
            "18:00-19:00",
            "19:00-20:00",
            "20:00-21:00",
            "21:00-22:00",
            "22:00-23:00",
            "23:00-24:00",
        };
        private List<string> Dates = new List<string>()
        {


            // "22-10-2021",
            // "23-10-2021",
            // "24-10-2021",
            // "25-10-2021",
            // "26-10-2021",
            // "27-10-2021",
            // "28-10-2021"
        };
        private void createDateTime()
        {


            var culture = new CultureInfo("de-DE");
            // Console.WriteLine(date.ToString(culture).Split(" ")[0].Replace(".", "-"));
            // Console.WriteLine(date.ToLocalTime());
            for (int i = 0; i < 7; i++)
            {
                DateTime date = DateTime.Today.AddDays(i);
                Dates.Add(date.ToString(culture).Split(" ")[0].Replace(".", "-"));
            }

        }
        public List<string> getDateTime()
        {


            var culture = new CultureInfo("de-DE");
            // Console.WriteLine(date.ToString(culture).Split(" ")[0].Replace(".", "-"));
            // Console.WriteLine(date.ToLocalTime());
            for (int i = 0; i < 7; i++)
            {
                DateTime date = DateTime.Today.AddDays(i);
                Dates.Add(date.ToString(culture).Split(" ")[0].Replace(".", "-"));
            }
            return Dates;
        }


        public List<List<obj>> createDynamicTable(List<Rezervation> rezervations)
        {
            createDateTime();
            List<List<obj>> rezervationArray = new List<List<obj>>();
            foreach (var item in Times)
            {
                List<obj> arrIn = new List<obj>();
                foreach (var item2 in Dates)
                {
                    var obj = new obj() { isEmpty = false, time = "", date = "" };
                    var res = isInculudeRezervation(item, item2, rezervations);
                    if (res)
                    {
                        obj.isEmpty = true;
                        obj.time = item;
                        obj.date = item2;
                    }
                    else
                    {
                        obj.isEmpty = false;
                        obj.time = item;
                        obj.date = item2;
                    }
                    arrIn.Add(obj);

                }
                rezervationArray.Add(arrIn);
            }
            return rezervationArray;
        }
        public bool isInculudeRezervation(string time, string date, List<Rezervation> rezervationInfo)
        {
            return rezervationInfo.Any(x => x.Tarih == date && x.Saat == time);
        }
    }
    public class obj
    {
        public bool isEmpty { get; set; }
        public string time { get; set; }
        public string date { get; set; }
    }
}