using Elmah;
using Request_form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_form
{
    public partial class RequestEdit : System.Web.UI.Page
    {
        CustomerRequestLogDBEntities1 db = new CustomerRequestLogDBEntities1();

        public int xx;
        tbl_Request emp = new tbl_Request();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xx = int.Parse(Session["RequestId"].ToString());

                emp = db.tbl_Request.Where(x => x.Id == xx).FirstOrDefault();
                if  (emp != null)
                {
                    this.txtFirstName.Text = emp.FirstName;
                    this.txtLastName.Text = emp.LastName;
                    this.txtAddress.Text = emp.Address;
                    this.txtPhoneNo.Text = emp.PhoneNo;
                    this.txtRequestNote.Text = emp.RequestNote;
                }      
              
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

            {  int xx = int.Parse(Session["RequestId"].ToString());
                CustomerRequestLogDBEntities1 EdittedRec = new CustomerRequestLogDBEntities1();
                var  empEditted = EdittedRec.tbl_Request.Where(x => x.Id == xx).FirstOrDefault();
                if (empEditted != null) 
                {
                    empEditted.FirstName = this.txtFirstName.Text;
                    empEditted.LastName = this.txtLastName.Text;
                    empEditted.Address = this.txtAddress.Text;
                    empEditted.PhoneNo = this.txtPhoneNo.Text;
                    empEditted.RequestNote = this.txtRequestNote.Text;
                    int i =  EdittedRec.SaveChanges();
                    //db.Entry(emp).State = System.Data.Entity.EntityState.Modified

                    if (i > 0)
                    {

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert",
                          "swal('Request was Successfully Updated','Thank you','success')", true);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert",
                          "swal('Unable to Update request ','something went wrong','error')", true);
                    }
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
                ErrorSignal.FromContext(Context).Raise(ex);
                
            }

        }
    }
}