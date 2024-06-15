using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EtityFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        studDBEntities dc = new studDBEntities();


        public void showData()
        {
            try
            {
                GridView1.DataSource = dc.studs.ToList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label5.Text = "Error Occured! " + ex.Message;
            }
            finally { }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            showData();
        }

  

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                stud addObj = new stud();
                addObj.rollno = Convert.ToInt32(txtRollno.Text);
                addObj.name = txtName.Text.ToString();
                addObj.address = txtAddress.Text .ToString();

                dc.studs.Add(addObj);
                dc.SaveChanges();
                showData();

              
            }
            catch (Exception ex)
            {
                Label5.Text = "Error Occured! " + ex.Message;
            }
            finally { }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                stud delObj = dc.studs.Find(Convert.ToInt32(txtRollno.Text));

                if (delObj != null)
                {
                    dc.studs.Remove(delObj);
                    dc.SaveChanges();
                    Label5.Text = "Deleted Succesfully";
                    showData();
                }
             
            }
            catch (Exception ex)
            {
                Label5.Text = "Error Occured! " + ex.Message;
            }
            finally { }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                stud updateObj = dc.studs.Find(Convert.ToInt32(txtRollno.Text));
                if (updateObj!=null)
                {
                    updateObj.name = txtName.Text.ToString();
                    updateObj.address = txtAddress.Text.ToString();
                    dc.SaveChanges();
                    showData();


                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Error Occured! " + ex.Message;
            }
            finally { }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                stud serObj = dc.studs.Find(Convert.ToInt32(txtRollno.Text));
                if (serObj != null)
                {
                    txtName.Text = serObj.name;
                    txtAddress.Text= serObj.address;


                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Error Occured! " + ex.Message;
            }
            finally { }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRollno.Text = GridView1.SelectedRow.Cells[1].Text;
            txtName.Text = GridView1.SelectedRow.Cells[2].Text;
            txtAddress.Text = GridView1.SelectedRow.Cells[3].Text;

        }


        protected void btnNext_Click(object sender, EventArgs e)
        {
          
            if(GridView1.PageIndex < GridView1.PageCount)
            {
                GridView1.PageIndex = GridView1.PageIndex + 1;
                GridView1.DataBind();
            }
            
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            GridView1.PageIndex = GridView1.PageIndex - 1;
            if(GridView1.PageIndex >0)
            {
                GridView1.PageIndex = 1;
            }
            GridView1.DataBind();
        }
    }
}