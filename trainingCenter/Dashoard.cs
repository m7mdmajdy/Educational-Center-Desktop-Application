﻿using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class Dashboard : MetroSetForm
    {
        

        EDPCenterEntities eDPCenterEntities;
        public Dashboard()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }

        
    }
}