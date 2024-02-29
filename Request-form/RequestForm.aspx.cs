using Request_form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_form
{
    public partial class RequestForm : System.Web.UI.Page
    {
        CustomerRequestLogDBEntities1 db = new CustomerRequestLogDBEntities1();

        public object Var { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (this.txtFirstName.Text == "")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", "swal('First Name','Please enter first name','info')", true);
                return;
            }
            else if (this.txtLastName.Text == "")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", "swal('Last Name','Please enter last name','info')", true);
                return;
            }

            else if (this.txtPhoneNo.Text == "")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", "swal('Phone Number','Please enter phone pumber','info')", true);
                return;
            }
            else if (this.txtRequestNote.Text == "")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", "swal('Request Note','Please enter the request','info')", true);
                return;
            }
            else

            {
                tbl_Request emp = new tbl_Request();
                emp.FirstName = this.txtFirstName.Text;
                emp.LastName = this.txtLastName.Text;
                emp.Address = this.txtAddress.Text;
                emp.PhoneNo = this.txtPhoneNo.Text;
                emp.RequestNote = this.txtRequestNote.Text;
                emp.RequestDate = System.DateTime.Now;
                db.tbl_Request.Add(emp);
                int i = db.SaveChanges();
                if (i > 0)
                {

                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert",
                      "swal('Request was Successfully Submitted','Thank you','success')", true);
                }
                else 
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert",
                      "swal('Unable to submit request ','something went wrong','error')", true);
                }

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try 
            {
                Response.Redirect("RequestDetails.aspx");
            }
            
           catch (Exception ex)
           {
            
           }

}
    }
}