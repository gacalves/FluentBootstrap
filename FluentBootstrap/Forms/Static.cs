﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Forms
{
    public class Static : FormControl
    {
        internal Static(BootstrapHelper helper) : base(helper, "p", "form-control-static")
        {
        }

        public interface ICreate : ICreateComponent
        {
        }
    }
}
