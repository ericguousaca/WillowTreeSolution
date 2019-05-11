﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    public class FaceGameBModel
    {
        public List<FaceGameItemBModel> FaceGameItemList { get; set; }
        public List<string> DistictFullNameList { get; set; }

        public FaceGameBModel()
        {
            this.FaceGameItemList = new List<FaceGameItemBModel> { };
            this.DistictFullNameList = new List<string> { };
        }
    }
}