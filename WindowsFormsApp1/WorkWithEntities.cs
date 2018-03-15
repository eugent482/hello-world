using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public class WorkWithEntities
    {
        private EFcontext _ef;

        public WorkWithEntities()
        {
            _ef = new EFcontext();
        }
        public void Dispose()
        {
            _ef.Dispose();
        }
        public TreeNode AddRoot(TreeView tree,string text)
        {
            try
            {
                Category category = new Category
                {
                    Name = text,
                    ParentId = null
                };
                _ef.Categories.Add(category);
                _ef.SaveChanges();
                Helper model = new Helper
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentID = category.ParentId

                };

                TreeNode node = new TreeNode();
                node.Text = text;
                node.Name = Guid.NewGuid().ToString();
                node.Tag = model;
                tree.Nodes.Add(node);
                return node;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Edit(TreeNode node,string newtext)
        {
            try
            {
                //MessageBox.Show(newtext);
                var model = (Helper)node.Tag;
                var category = _ef.Categories.Find(model.Id);
                //MessageBox.Show($"{category.Name}  {newtext}");
                category.Name = newtext;
               // MessageBox.Show("2");
                _ef.SaveChanges();
               // MessageBox.Show("3");
                node.Text = newtext;
                node.Tag = new Helper
                {
                    Id = category.Id,
                    Name = newtext,
                    ParentID = category.ParentId
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public TreeNode AddNode(TreeNode parent, string text)
        {
            try
            {
             
                var model = (Helper)parent.Tag;
                Category category = new Category
                {
                    Name = text,
                    ParentId = model.Id
                };
                _ef.Categories.Add(category);
                _ef.SaveChanges();

                TreeNode node = new TreeNode();
                node.Text = text;
                node.Name = Guid.NewGuid().ToString();
                node.Tag = new Helper
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentID = category.ParentId
                };
                parent.Nodes.Add(node);
                return node;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return parent;
            }
        }

        public TreeNode GetParentSubNodes(TreeNode parent)
        {
            try
            {
                var model = (Helper)parent.Tag;
                var query = from c in _ef.Categories
                            where c.ParentId == model.Id
                            orderby c.Name
                            select new Helper
                            {
                                Id = c.Id,
                                Name = c.Name,
                                ParentID = c.ParentId
                            };
                parent.Nodes.Clear();
                foreach (var item in query)
                {
                    TreeNode node = new TreeNode();
                    node.Text = item.Name;
                    node.Name = Guid.NewGuid().ToString();
                    node.Tag = item;
                    //???
                    node.Nodes.Add("");
                    parent.Nodes.Add(node);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return parent;
        }

        public void LoadTree(TreeView tree)
        {
            try
            {
                var query = from c in _ef.Categories
                            where c.ParentId == null
                            orderby c.Name
                            select new Helper
                            {
                                Id = c.Id,
                                Name = c.Name,
                                ParentID = c.ParentId
                            };
                foreach (var item in query)
                {
                    TreeNode node = new TreeNode();
                    node.Text = item.Name;
                    node.Name = Guid.NewGuid().ToString();
                    node.Tag = item;
                    //???
                    node.Nodes.Add("");
                    tree.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Remove(TreeView tree,TreeNode node)
        {
            try
            {
                var model = (Helper)node.Tag;
                var category =_ef.Categories.Include(i => i.Children).SingleOrDefault(c => c.Id == model.Id);


                if (category != null)
                {
                    if (category.Children.Count == 0)
                    {
                        _ef.Categories.Remove(category);
                        _ef.SaveChanges();
                        tree.Nodes.Remove(node);
                    }
                    else
                    {
                        MessageBox.Show("Спочатку видаліть дочірні елементи");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
