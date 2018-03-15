using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        WorkWithEntities _wf;
        public Form1()
        {
            _wf = new WorkWithEntities();
            InitializeComponent();
            var img = new Bitmap("test3.png");
            imgList.Images.Add(img);
            var img2 = new Bitmap("test2.png");
            imgList.Images.Add(img2);
            var img3 = new Bitmap("test.png");
            imgList.Images.Add(img3);

            listViewFind.LargeImageList = imgList;
            listViewFind.Columns.Add("Name");
            listViewFind.Columns[0].Width = listViewFind.Width + 100;

            listViewUp.LargeImageList = imgList;
            listViewUp.Columns.Add("Name");
            listViewUp.Columns[0].Width = listViewFind.Width + 100;

            treeView.ImageList = imgList;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.Focus();
                AddEditForm editForm = new AddEditForm();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _wf.Edit(treeView.SelectedNode, editForm.CategoryName);
                }
            }
        }

        private void btnaddroot_Click(object sender, EventArgs e)
        {
            AddEditForm editForm = new AddEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                TreeNode node= _wf.AddRoot(treeView, editForm.CategoryName);
                if(node!=null)
                {
                    treeView.SelectedNode = node;
                    treeView.Focus();
                }
               
            }
        }

        private void btnaddleaf_Click(object sender, EventArgs e)
        {

            if (treeView.SelectedNode != null)
            {
                treeView.Focus();
                AddEditForm editForm = new AddEditForm();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    TreeNode node = _wf.AddNode(treeView.SelectedNode, editForm.CategoryName);
                    treeView.SelectedNode = node;
                    treeView.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _wf.LoadTree(treeView);
            treeView.SelectedNode = null;
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                TreeNode node = _wf.GetParentSubNodes(e.Node);
            }
        }

        private void btnrem_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.Focus();
                var name = treeView.SelectedNode.Text;
                DialogResult result = MessageBox.Show($"Дійсно видалити категорію: {name}?", "Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _wf.Remove(treeView, treeView.SelectedNode);
                }
            }
        }



        private void checknode(TreeNode parentnode, string name)
        {
            try
            {
                var helper = (Helper)parentnode.Tag;
                if (parentnode.Text.ToUpper().Contains(tbfind.Text.ToUpper()))
                {
                    ListViewItem item = new ListViewItem { Text = name + " > " + parentnode.Text, Tag = parentnode,ImageIndex=2 };
                    listViewFind.Items.Add(item);
                }

                TreeNode node = _wf.GetParentSubNodes(parentnode);
                if (parentnode.Nodes.Count != 0)
                {
                    foreach (var nodes in parentnode.Nodes)
                    {
                        TreeNode it = (TreeNode)nodes;
                        checknode(it, name + " > " + parentnode.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbfind_TextChanged(object sender, EventArgs e)
        {
            listViewFind.Items.Clear();
            //listViewFind.Columns.Add("Name");
            //listViewFind.Columns[0].Width = listViewFind.Width +100;
            if (tbfind.Text != string.Empty)
            {
                foreach (TreeNode _parentNode in treeView.Nodes)
                {
                    var item = (Helper)_parentNode.Tag;
                    if (item.ParentID == null)
                        checknode(_parentNode, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewFind.SelectedItems.Count > 0)
            {
                var item = listViewFind.SelectedItems[0];
                TreeNode node = (TreeNode)item.Tag;
                treeView.CollapseAll();
                treeView.SelectedNode = node;
                treeView.Focus();

            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private string getparentname(TreeNode node)
        {
            var item = (Helper)node.Tag;
            if (item.ParentID == null)
            {
                return ">" + node.Text;
            }
            else
            {
                return getparentname(node.Parent) + ">" + node.Text;
            }

        }
        private void btnright_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.Focus();
                string name = getparentname(treeView.SelectedNode);
                ListViewItem item = new ListViewItem { Text=name,Name=name, Tag = treeView.SelectedNode.Tag,ImageIndex=1 };
                if (!listViewUp.Items.ContainsKey(name))
                    listViewUp.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewUp.SelectedItems.Count > 0)
            {
                var item = listViewUp.SelectedItems[0];
                listViewUp.Items.Remove(item);
            }
        }
    }
}
