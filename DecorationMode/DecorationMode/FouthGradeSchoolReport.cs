﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    public class FouthGradeSchoolReport : SchoolReport
    {
        override public void report()
        {
            Console.WriteLine("尊敬的XXX家长:");
            Console.WriteLine("......");
            Console.WriteLine("语文 62 数学 65 体育 98 自然 63");
            Console.WriteLine("......");
            Console.WriteLine("家长签名：");
        }

        override public void sign(string name)
        {
            Console.WriteLine(name);
        }
    }
}
