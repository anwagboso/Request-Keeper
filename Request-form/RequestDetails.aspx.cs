using Elmah;
using Request_form.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_form
{
    public partial class RequestDetails : System.Web.UI.Page
    {

        CustomerRequestLogDBEntities1 db = new CustomerRequestLogDBEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dgDetails.DataSource = db.tbl_Request.OrderByDescending(x => x.Id).ToList();
                dgDetails.DataBind();
            }
               
        }

        protected void dgDetails_PreRender(object sender, EventArgs e)
        {
            if ((dgDetails.Rows.Count > 0))
            {
                // Replace the <td> with <th> and adds the scope attribute
                dgDetails.UseAccessibleHeader = true;

                // Adds the <thead> and <tbody> elements required for DataTables to work
                dgDetails.HeaderRow.TableSection = TableRowSection.TableHeader;

                // Adds the <tfoot> element required for DataTables to work
                dgDetails.FooterRow.TableSection = TableRowSection.TableFooter;
            }
        }

        protected void btnCreateNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("RequestForm.aspx");
            }

            catch (Exception ex)
            {
                ErrorSignal.FromContext(Context).Raise(ex);
            }
        }

        protected void dgDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdateRequest")
            {
                // Convert the row index stored in the CommandArgument

                // property to an Integer.

                int index = Convert.ToInt32(e.CommandArgument);
               
                // Retrieve the row that contains the button clicked

                // by the user from the Rows collection.

                GridViewRow row = dgDetails.Rows[index];
                

                //string ID = dgDetails.DataKeys[row.RowIndex].ToString();

                string xx = row.Cells[0].Text;
               //string xs = row.Cells[9].Text;  // check for Elmah error log
                Session["RequestId"] = xx;
                Response.Redirect("RequestEdit.aspx");
            }
        }

       
    }
}