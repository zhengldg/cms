using System;
using System.Web.UI.WebControls;

namespace SiteServer.Utils.Enumerations
{

    public enum EStatictisXType
    {
        Hour,          //小时
        Day,            //日
        Month,       //月
        Year,           //年
    }

    public class EStatictisXTypeUtils
    {
        public static string GetValue(EStatictisXType type)
        {
            if (type == EStatictisXType.Hour)
            {
                return "Hour";
            }
            if (type == EStatictisXType.Day)
            {
                return "Day";
            }
            if (type == EStatictisXType.Month)
            {
                return "Month";
            }
            if (type == EStatictisXType.Year)
            {
                return "Year";
            }
            throw new Exception();
        }

        public static string GetText(EStatictisXType type)
        {
            if (type == EStatictisXType.Hour)
            {
                return "时";
            }
            if (type == EStatictisXType.Day)
            {
                return "日";
            }
            if (type == EStatictisXType.Month)
            {
                return "月";
            }
            if (type == EStatictisXType.Year)
            {
                return "年";
            }
            throw new Exception();
        }

        public static EStatictisXType GetEnumType(string typeStr)
        {
            var retVal = EStatictisXType.Day;

            if (Equals(EStatictisXType.Hour, typeStr))
            {
                retVal = EStatictisXType.Hour;
            }
            else if (Equals(EStatictisXType.Day, typeStr))
            {
                retVal = EStatictisXType.Day;
            }
            else if (Equals(EStatictisXType.Month, typeStr))
            {
                retVal = EStatictisXType.Month;
            }
            else if (Equals(EStatictisXType.Year, typeStr))
            {
                retVal = EStatictisXType.Year;
            }

            return retVal;
        }

        public static bool Equals(EStatictisXType type, string typeStr)
        {
            if (string.IsNullOrEmpty(typeStr)) return false;
            if (string.Equals(GetValue(type).ToLower(), typeStr.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static bool Equals(string typeStr, EStatictisXType type)
        {
            return Equals(type, typeStr);
        }

        public static ListItem GetListItem(EStatictisXType type, bool selected)
        {
            var item = new ListItem(GetText(type), GetValue(type));
            if (selected)
            {
                item.Selected = true;
            }
            return item;
        }

        public static void AddListItems(ListControl listControl)
        {
            if (listControl != null)
            {
                listControl.Items.Add(GetListItem(EStatictisXType.Day, false));
                listControl.Items.Add(GetListItem(EStatictisXType.Month, false));
                listControl.Items.Add(GetListItem(EStatictisXType.Year, false));
            }
        }

    }
}
