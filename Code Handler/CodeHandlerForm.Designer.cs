namespace Code_Handler
{
    partial class CodeHandlerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeHandlerForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeList = new System.Windows.Forms.ListBox();
            this.categoriesView = new System.Windows.Forms.TreeView();
            this.onHoldList = new System.Windows.Forms.ListBox();
            this.lblCodeList = new System.Windows.Forms.Label();
            this.lblOnHold = new System.Windows.Forms.Label();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(16, 17);
            this.statusText.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCodesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            // 
            // loadCodesToolStripMenuItem
            // 
            this.loadCodesToolStripMenuItem.Name = "loadCodesToolStripMenuItem";
            this.loadCodesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadCodesToolStripMenuItem.Text = "Load Codes...";
            this.loadCodesToolStripMenuItem.Click += new System.EventHandler(this.loadCodesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // codeList
            // 
            this.codeList.FormattingEnabled = true;
            this.codeList.Location = new System.Drawing.Point(198, 40);
            this.codeList.Name = "codeList";
            this.codeList.Size = new System.Drawing.Size(344, 199);
            this.codeList.TabIndex = 2;
            this.codeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.codeList_MouseDoubleClick);
            // 
            // categoriesView
            // 
            this.categoriesView.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesView.Location = new System.Drawing.Point(0, 24);
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.Size = new System.Drawing.Size(192, 404);
            this.categoriesView.TabIndex = 4;
            this.categoriesView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoriesView_AfterSelect);
            this.categoriesView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.categoriesView_NodeMouseClick);
            // 
            // onHoldList
            // 
            this.onHoldList.FormattingEnabled = true;
            this.onHoldList.Location = new System.Drawing.Point(198, 262);
            this.onHoldList.Name = "onHoldList";
            this.onHoldList.Size = new System.Drawing.Size(343, 160);
            this.onHoldList.TabIndex = 5;
            this.onHoldList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onHoldList_MouseDoubleClick);
            this.onHoldList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onHoldList_MouseDown);
            // 
            // lblCodeList
            // 
            this.lblCodeList.AutoSize = true;
            this.lblCodeList.Location = new System.Drawing.Point(198, 24);
            this.lblCodeList.Name = "lblCodeList";
            this.lblCodeList.Size = new System.Drawing.Size(268, 13);
            this.lblCodeList.TabIndex = 6;
            this.lblCodeList.Text = "Available for use: (Double click to move to \'On hold\'-list)";
            // 
            // lblOnHold
            // 
            this.lblOnHold.AutoSize = true;
            this.lblOnHold.Location = new System.Drawing.Point(199, 246);
            this.lblOnHold.Name = "lblOnHold";
            this.lblOnHold.Size = new System.Drawing.Size(267, 13);
            this.lblOnHold.TabIndex = 7;
            this.lblOnHold.Text = "On Hold/Waiting for ok: (Double click to move to trash)";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // moveDirectlyToTrashOnDblClickToolStripMenuItem
            // 
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem.Name = "moveDirectlyToTrashOnDblClickToolStripMenuItem";
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem.Text = "Move directly to trash on Dbl Click";
            this.moveDirectlyToTrashOnDblClickToolStripMenuItem.Click += new System.EventHandler(this.moveDirectlyToTrashOnDblClickToolStripMenuItem_Click);
            // 
            // CodeHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.lblOnHold);
            this.Controls.Add(this.lblCodeList);
            this.Controls.Add(this.onHoldList);
            this.Controls.Add(this.categoriesView);
            this.Controls.Add(this.codeList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodeHandlerForm";
            this.Text = "CC Code Handler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCodesToolStripMenuItem;
        private System.Windows.Forms.ListBox codeList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView categoriesView;
        private System.Windows.Forms.ListBox onHoldList;
        private System.Windows.Forms.Label lblCodeList;
        private System.Windows.Forms.Label lblOnHold;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDirectlyToTrashOnDblClickToolStripMenuItem;
    }
}

