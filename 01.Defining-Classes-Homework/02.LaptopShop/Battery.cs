using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


class Battery
{
    private string type;
    private string hours;

    public Battery(string type)
    {
        this.Type = type;
    }

    public Battery(string type, string hours):this(type)
    {
        this.Hours = hours;
    }

    public string Type
    {
        get { return this.type; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Battery type can not be empty!");
            }
            this.type = value; 
        }
    }
    public string Hours
    {
        get { return this.hours; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Battery endurance can not be empty!");
            }
            Regex matcher = new Regex(@"\-*\d+\.*\d*");
            Match match = matcher.Match(value);
            string strEndurance;
            float endurance;
            if(match.Success)
            {
                strEndurance = match.Value;
                endurance = float.Parse(strEndurance);
                if(endurance < 0.1)
                {
                    throw new ArgumentOutOfRangeException("Battery endurance can not be negative!");
                }
            }         
            this.hours = value;
        }
    }

    public override string ToString()
    {
        StringBuilder resultStr = new StringBuilder();
        if(this.type != null)
        {
            resultStr.AppendLine("Battery Type: "+this.type);
        }
        if(this.type != null)
        {
            resultStr.AppendLine("Battery Endurance: "+this.hours);
        }
        return resultStr.ToString();
    }
}

