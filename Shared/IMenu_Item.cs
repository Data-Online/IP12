﻿
using Microsoft.VisualBasic;
  
namespace IPv5.UI
{

  

    public interface IMenu_Item {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  