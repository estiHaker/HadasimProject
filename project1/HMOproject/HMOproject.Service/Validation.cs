using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Service
{
    public class Validation
    {
        //בדיקה אם הטקסט מספר  
        public static bool IsNum(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }

            return true;
        }
        public static bool IsNumMinos(string s)
        {
            if ((s[0].ToString() != "-"))
                return false;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }

            return true;
        }


        //בדיקת תקינות טלפון  
        public static bool IsTel(string s)
        {

            if (s == "")
                return true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }
            if (s.IndexOf('0') != 0 && s.Length == 8)
                return true;
            if (s.IndexOf('0') != 0 || s.Length != 9)
                return false;
            return true;
        }
        //בדיקת תקינות פלפון  
        public static bool IsPelepon(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }
            if (s.IndexOf('0') != 0 && s.Length == 9)
                return true;
            if (s.IndexOf('0') != 0 || s.Length != 10)
                return false;
            return true;
        }

        //בדיקת תקינות ת.ז
        public static bool CheckId(int d)
        {
          string ds=d.ToString();
            if (!Validation.IsNum(ds))
                return false;
            while (ds.Length < 9)
            {
                ds = "0" + ds;
            }


            int s = 0, t;
            for (int i = 0; i < ds.Length; i++)
            {
                if (i % 2 == 0)// הראשון זוגי להכפיל ב1  
                {
                    s += Convert.ToInt32(ds[i].ToString());
                }
                if (i % 2 != 0)
                {
                    t = Convert.ToInt32(ds[i].ToString()) * 2;
                    if (t < 10)
                        s += t;
                    else
                        s += t % 10 + t / 10;

                }
            }

            if (s % 10 == 0)
                return true;
            return false;

        }

        //בדיקה אם הטקסט באנגלית
        public static bool IsEnglish(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < 'a' || s[i] > 'z') && (s[i] != ' ') && (s[i] < 'A' || s[i] > 'Z'))
                    return false;
            }

            return true;
        }

        public static bool isMember(Members members)
        {
            if (members == null)
            {
                return false;
            }
            if (Validation.IsEnglish(members.Name) && Validation.IsEnglish(members.LastName) && Validation.IsEnglish(members.Address))
                if (Validation.CheckId(members.Id))
                    if (Validation.IsTel(members.Phone) && Validation.IsPelepon(members.MobilePhone))
                        if(DateTime.Now.Date>members.Dob.Date)
                            return true;
            return false;
        }
        public static bool isMemberUpdate(Members members)
        {
            if (members == null)
            {
                return false;
            }
            if (Validation.IsEnglish(members.Name) && Validation.IsEnglish(members.LastName) && Validation.IsEnglish(members.Address))
                if (Validation.CheckId(members.Id))
                    if (Validation.IsTel(members.Phone) && Validation.IsPelepon(members.MobilePhone))
                        if (DateTime.Now.Date > members.Dob.Date)
                            if(members.Recovery>members.Ill)
                                      return true;
            return false;
        }
        public static bool addVac(Vaccination vaccination)
        {
            if (vaccination.DateOfVaccination>DateTime.Now)
                if(vaccination.Manufacturer==null||vaccination.Members==null)
                    return false;
            return true;
        }

    }
}
