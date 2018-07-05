
using Microsoft.VisualBasic;
  
namespace IPv5.UI
{

  

    public interface IFooter {

#region Interface Properties
        
        System.Web.UI.WebControls.Literal Copyright {get;}
                
        System.Web.UI.WebControls.Literal Copyright1 {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  