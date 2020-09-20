using System;
using System.Data;
using System.Web.UI;

namespace TreeViewAndDataList
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("studentdetails.xml"));
            if (ds != null && ds.HasChanges())
            {
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataBind();
            }
        }

    }
}