﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class MaterialsManagement_Template : HAWK_Template_2
    {
        public MaterialsManagement_Template()
        {
            InitializeComponent();
        }
        public MaterialsManagement_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

    }
}
