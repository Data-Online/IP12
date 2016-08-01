
using Microsoft.VisualBasic;
  
namespace IPv5.UI
{

  

    public interface IThemeButtonWithArrow {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
        System.Web.UI.WebControls.Image ArrowImage {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  