using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(fuPhotos.HasFile)
            {
                //fuPhotos.SaveAs(@"D:\FATraining\Temp\myfile.jpg");
                var basePath = Server.MapPath(".");
                var fileInfo = new FileInfo(fuPhotos.FileName);
                var fileName = Guid.NewGuid().ToString() + "." + fileInfo.Extension;
                fuPhotos
                    .SaveAs($@"{basePath}\Images\{fileName}");

                Image1.ImageUrl = "/Images/" + fileName;
            }
        }
    }
}