using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Code_Handler
{
    public partial class CodeHandlerForm : Form
    {
        public static string ROOT = "Root";
        public static string CONTAINER = "CONTAINER";
        public static string CAMO = "CAMO";
        public static string OTHER = "OTHER";

        private ContextMenu contextMnu = new ContextMenu();
        MenuItem DeleteTrash = new MenuItem("Delete all");
        MenuItem RestoreTrash = new MenuItem("Restore all");

        private ContextMenu contextMnuMoveToTrash = new ContextMenu();
        MenuItem MoveToTrash = new MenuItem("Move To Trash");

        private ContextMenu onHoldMenu = new ContextMenu();
        MenuItem RestoreItem = new MenuItem("Restore code");

        private string onHoldSelectionRestore = "";

        public CodeHandlerForm()
        {
            InitializeComponent();
            LoadCategoriesView();

            contextMnu.MenuItems.Add(DeleteTrash);
            DeleteTrash.Click += new EventHandler(DeleteTrash_Click);
            contextMnu.MenuItems.Add(RestoreTrash);
            RestoreTrash.Click += new EventHandler(RestoreTrash_Click);

            onHoldMenu.MenuItems.Add(RestoreItem);
            RestoreItem.Click += new EventHandler(RestoreItem_Click);

            contextMnuMoveToTrash.MenuItems.Add(MoveToTrash);
            MoveToTrash.Click += new EventHandler(MoveToTrash_Click);
        }

        private void LoadCategoriesView()
        {
            categoriesView.Nodes.Clear();
            TreeNode Root = new TreeNode("Categories");
            Root.Tag = ROOT;
            categoriesView.Nodes.Add(Root);

            TreeNode camos = new TreeNode("Camoflages");
            camos.Tag = CAMO;
            Root.Nodes.Add(camos);

            TreeNode containers = new TreeNode("CC Containers");
            containers.Tag = CONTAINER;
            Root.Nodes.Add(containers);

            TreeNode other = new TreeNode("Other");
            other.Tag = OTHER;
            Root.Nodes.Add(other);

            TreeNode deleted = new TreeNode("Deleted/Used codes");
            deleted.Tag = "DEL";
            Root.Nodes.Add(deleted);

            Root.ExpandAll();
            LoadCodes();
            statusText.Text = "Ready.";
        }

        private void LoadCodes()
        {
            string fileName = GetCodesFileName();
            if ( File.Exists(fileName))
            {
                Program.AllCodes = BinarySerialize.Read2<List<Code>>(fileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void categoriesView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Tag.Equals(ROOT)) { return; }
                Console.WriteLine(e.Node.Tag.ToString());

                codeList.Items.Clear();
                onHoldList.Items.Clear();

                string tag = e.Node.Tag.ToString();
                foreach(Code code in Program.AllCodes)
                {
                    if ( code.Category.Equals(tag) && code.IsDeleted == false)
                    {
                        if ( code.OnHold )
                        {
                            onHoldList.Items.Add(code.ID);
                        } else
                        {
                            codeList.Items.Add(code.ID);
                        }
                    } else if ( tag.Equals("DEL") && code.IsDeleted )
                    {
                        codeList.Items.Add(code.ID);
                    }
                }

                if ( tag.Equals("DEL"))
                {
                    onHoldList.Enabled = false;
                    lblOnHold.Enabled = false;
                    lblCodeList.Text = "Codes used/in trash can: (Double click to delete/restore)";
                } else
                {
                    onHoldList.Enabled = true;
                    lblOnHold.Enabled = true;
                    lblCodeList.Text = GetCodeListHeadline();
                }
                statusText.Text = "Selected '" + e.Node.Text + "'.";
            }
        }

        private string GetCodeListHeadline()
        {
            if ( moveDirectlyToTrashOnDblClickToolStripMenuItem.Checked )
            {
                return "Available for use: (Double click to move to trash)";
            }
            return "Available for use: (Double click to move to 'On hold'-list)";
        }

        private void codeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListBox)sender;
            string itemClicked = senderList.SelectedItem.ToString();
            
            Console.WriteLine(itemClicked);
            Clipboard.SetText(itemClicked);
            statusText.Text = "Item '" + itemClicked + "' has been copied.";

            Code code = Program.AllCodes.Find(c => c.ID == itemClicked);
            if ( code.IsDeleted )
            {
                if (MessageBox.Show("Do You want to permanently delete this item?","Delete item",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    senderList.Items.Remove(itemClicked);
                    RemoveItemFromCodeList(itemClicked);
                    statusText.Text = "'" + itemClicked + "' has been permanently deleted.";
                } else if ( MessageBox.Show("Do You want to restore this item?","Item restore",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    senderList.Items.Remove(itemClicked);
                    code.IsDeleted = false;
                    code.OnHold = false;
                    statusText.Text = "'" + itemClicked + "' has been restored.";
                }
            } else
            {
                if ( moveDirectlyToTrashOnDblClickToolStripMenuItem.Checked )
                {
                    code.IsDeleted = true;
                } else
                {
                    code.OnHold = true;
                    onHoldList.Items.Add(itemClicked);
                }
                senderList.Items.Remove(itemClicked);
            }
        }

        private void onHoldList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ListBox OnHoldList = (ListBox)sender;
            string clicked = OnHoldList.SelectedItem.ToString();
            Code code = Program.AllCodes.Find(c => c.ID == clicked);
            code.IsDeleted = true;
            OnHoldList.Items.Remove(clicked);
            statusText.Text = "'" + clicked + "' has been sent to trash.";
        }

        private void RemoveItemFromCodeList(string text)
        {
            Code code = Program.AllCodes.Find(c => c.ID == text);
            Program.AllCodes.Remove(code);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Saving...");
            BinarySerialize.WriteToBinaryFile<List<Code>>(GetCodesFileName(), Program.AllCodes);
        }

        private string GetCodesFileName()
        {
            string currentDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = currentDir + @"\codes.obj";
            return fileName;
        }

        private void categoriesView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if ( e.Node.Tag.Equals("DEL"))
            {
                contextMnu.Show(categoriesView, e.Location);
            } else
            {
                contextMnuMoveToTrash.Show(categoriesView, e.Location);
            }
        }

        private void MoveToTrash_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Move all items to trash...");
            if ( MessageBox.Show("Are You sure You want to delete every item in this category?","Move to trash",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes )
            {
                foreach(string item in codeList.Items)
                {
                    Code code = Program.AllCodes.Find(c => c.ID == item);
                    code.IsDeleted = true;
                }
                foreach(string item in onHoldList.Items)
                {
                    Code code = Program.AllCodes.Find(c => c.ID == item);
                    code.IsDeleted = true;
                }
                int no = codeList.Items.Count + onHoldList.Items.Count;
                codeList.Items.Clear();
                onHoldList.Items.Clear();
                statusText.Text = "All " + no + " items has been moved to trash.";
            }
        }

        private void DeleteTrash_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete");
            if ( MessageBox.Show("Are You sure You want to DELETE all items in trash?\nThis action is permanent and can not be reversed!","Delete Trash",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach(string itm in codeList.Items)
                {
                    RemoveItemFromCodeList(itm);
                }
                int no = codeList.Items.Count;
                codeList.Items.Clear();
                statusText.Text = "All " + no + " items has been deleted";
            }
        }

        private void RestoreTrash_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Restore");
            if (MessageBox.Show("Are You sure You want to RESTORE all items in trash?", "Restore Trash", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach (string itm in codeList.Items)
                {
                    Code code = Program.AllCodes.Find(c => c.ID == itm);
                    code.IsDeleted = false;
                    //code.OnHold = false;
                }
                int no = codeList.Items.Count;
                codeList.Items.Clear();
                statusText.Text = "All " + no + " items has been restored.";
            }
        }
        
        private void RestoreItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Restore item...");
            Code code = Program.AllCodes.Find(c => c.ID == onHoldSelectionRestore);
            code.OnHold = false;
            codeList.Items.Add(onHoldSelectionRestore);
            onHoldList.Items.Remove(onHoldSelectionRestore);
            statusText.Text = "'" + onHoldSelectionRestore + "' has been restored for use";
            onHoldSelectionRestore = "";

        }

        private void loadCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeImport code = new CodeImport();
            code.Show();
        }

        private void onHoldList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = onHoldList.IndexFromPoint(e.Location);
            if ( index != ListBox.NoMatches )
            {
                onHoldSelectionRestore = onHoldList.Items[index].ToString();
                onHoldMenu.MenuItems[0].Text = "Restore " + onHoldSelectionRestore;
                onHoldMenu.Show(onHoldList, e.Location);
                
            } else
            {
                onHoldSelectionRestore = "";
            }
        }

        private void moveDirectlyToTrashOnDblClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itm = (ToolStripMenuItem)sender;
            itm.Checked = !itm.Checked;

            onHoldList.Enabled = !onHoldList.Enabled;
            lblOnHold.Enabled = !lblOnHold.Enabled;
            lblCodeList.Text = GetCodeListHeadline();
        }
    }
}
