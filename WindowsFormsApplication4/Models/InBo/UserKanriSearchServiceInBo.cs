﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordConvTool.Service;

namespace WordConverter_v2.Models.InBo
{
    public class UserKanriSearchServiceInBo : IBo
    {
        public String userName { get; set; }
        public String empId { get; set; }
        public int kengenSelectedIndex { get; set; }
    }
}
