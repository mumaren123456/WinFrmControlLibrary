using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlLibrary
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class UserControlDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        public override void InitializeNewComponent(System.Collections.IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);
            ((UserControlEx)(this.Component)).Text = "";
        }
    }
}
