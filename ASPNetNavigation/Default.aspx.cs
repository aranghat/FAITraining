using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetNavigation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var rootNode = TreeView1.Nodes[0];
            GetFolderNodes(@"D:\FATraining", rootNode);
        }

        void GetFolderNodes(string folderPath,TreeNode node)
        {
            var subDirs = new DirectoryInfo(folderPath).EnumerateDirectories();

            foreach(var d in subDirs)
            {
                TreeNode childNode = new TreeNode(d.Name);
                node.ChildNodes.Add(childNode);


                GetFolderNodes(d.FullName, childNode);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl 
                = DropDownList1.SelectedValue;
            HyperLink1.Text 
                = DropDownList1.SelectedItem.Text;

            TreeView1.Nodes[0].ChildNodes[0]
                .ChildNodes[0].ChildNodes.Add(new TreeNode(DropDownList1.SelectedItem.Text, DropDownList1.SelectedValue));
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        //void GetNodes(string directoryPath,TreeNode node)
        //{
        //    var subDirectories = new DirectoryInfo(directoryPath).EnumerateDirectories();
        //    if(subDirectories.Count() > 0)
        //    {
        //        foreach(var di in subDirectories)
        //        {
        //            var childNode = new TreeNode(di.Name);
        //            node.ChildNodes.Add(childNode);

        //            var files = new DirectoryInfo(di.FullName).EnumerateFiles();
        //            foreach (var fi in files)
        //            {
        //                var fileNode = new TreeNode(fi.Name);
        //                childNode.ChildNodes.Add(fileNode);
        //            }

        //            GetNodes(di.FullName, childNode);
        //        }
        //    }
        //}
    }
}