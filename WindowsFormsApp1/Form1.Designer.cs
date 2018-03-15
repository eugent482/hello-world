namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.listViewUp = new System.Windows.Forms.ListView();
            this.listViewFind = new System.Windows.Forms.ListView();
            this.tbfind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnaddroot = new System.Windows.Forms.Button();
            this.btnrem = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnaddleaf = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(13, 13);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(270, 269);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // listViewUp
            // 
            this.listViewUp.FullRowSelect = true;
            this.listViewUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewUp.Location = new System.Drawing.Point(383, 12);
            this.listViewUp.Name = "listViewUp";
            this.listViewUp.Size = new System.Drawing.Size(301, 97);
            this.listViewUp.TabIndex = 1;
            this.listViewUp.TileSize = new System.Drawing.Size(500, 20);
            this.listViewUp.UseCompatibleStateImageBehavior = false;
            this.listViewUp.View = System.Windows.Forms.View.Tile;
            // 
            // listViewFind
            // 
            this.listViewFind.FullRowSelect = true;
            this.listViewFind.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFind.Location = new System.Drawing.Point(383, 166);
            this.listViewFind.MultiSelect = false;
            this.listViewFind.Name = "listViewFind";
            this.listViewFind.Size = new System.Drawing.Size(301, 145);
            this.listViewFind.TabIndex = 2;
            this.listViewFind.TileSize = new System.Drawing.Size(500, 20);
            this.listViewFind.UseCompatibleStateImageBehavior = false;
            this.listViewFind.View = System.Windows.Forms.View.Tile;
            // 
            // tbfind
            // 
            this.tbfind.Location = new System.Drawing.Point(383, 140);
            this.tbfind.Name = "tbfind";
            this.tbfind.Size = new System.Drawing.Size(301, 20);
            this.tbfind.TabIndex = 3;
            this.tbfind.TextChanged += new System.EventHandler(this.tbfind_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(298, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnright
            // 
            this.btnright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnright.Location = new System.Drawing.Point(319, 32);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(27, 24);
            this.btnright.TabIndex = 5;
            this.btnright.Text = "->";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(319, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaddroot
            // 
            this.btnaddroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnaddroot.Location = new System.Drawing.Point(13, 289);
            this.btnaddroot.Name = "btnaddroot";
            this.btnaddroot.Size = new System.Drawing.Size(63, 23);
            this.btnaddroot.TabIndex = 7;
            this.btnaddroot.Text = "Add root";
            this.btnaddroot.UseVisualStyleBackColor = true;
            this.btnaddroot.Click += new System.EventHandler(this.btnaddroot_Click);
            // 
            // btnrem
            // 
            this.btnrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrem.Location = new System.Drawing.Point(151, 289);
            this.btnrem.Name = "btnrem";
            this.btnrem.Size = new System.Drawing.Size(63, 23);
            this.btnrem.TabIndex = 8;
            this.btnrem.Text = "Remove";
            this.btnrem.UseVisualStyleBackColor = true;
            this.btnrem.Click += new System.EventHandler(this.btnrem_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnedit.Location = new System.Drawing.Point(220, 289);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(63, 23);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnaddleaf
            // 
            this.btnaddleaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnaddleaf.Location = new System.Drawing.Point(82, 289);
            this.btnaddleaf.Name = "btnaddleaf";
            this.btnaddleaf.Size = new System.Drawing.Size(63, 23);
            this.btnaddleaf.TabIndex = 10;
            this.btnaddleaf.Text = "Add leaf";
            this.btnaddleaf.UseVisualStyleBackColor = true;
            this.btnaddleaf.Click += new System.EventHandler(this.btnaddleaf_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 326);
            this.Controls.Add(this.btnaddleaf);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnrem);
            this.Controls.Add(this.btnaddroot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbfind);
            this.Controls.Add(this.listViewFind);
            this.Controls.Add(this.listViewUp);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listViewUp;
        private System.Windows.Forms.ListView listViewFind;
        private System.Windows.Forms.TextBox tbfind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnaddroot;
        private System.Windows.Forms.Button btnrem;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnaddleaf;
        private System.Windows.Forms.ImageList imgList;
    }
}

