namespace TestApp.Views
{
    partial class ErrorListView
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
            this.KeyNumberLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SearchErrorListButton = new System.Windows.Forms.Button();
            this.ErrorDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedItemDataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemErrorAggregationLink = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHistoriyReferenceLink = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyNumberLabel
            // 
            this.KeyNumberLabel.AutoSize = true;
            this.KeyNumberLabel.Location = new System.Drawing.Point(17, 11);
            this.KeyNumberLabel.Name = "KeyNumberLabel";
            this.KeyNumberLabel.Size = new System.Drawing.Size(16, 12);
            this.KeyNumberLabel.TabIndex = 1;
            this.KeyNumberLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(19, 26);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 19);
            this.IdTextBox.TabIndex = 2;
            // 
            // SearchErrorListButton
            // 
            this.SearchErrorListButton.Location = new System.Drawing.Point(138, 24);
            this.SearchErrorListButton.Name = "SearchErrorListButton";
            this.SearchErrorListButton.Size = new System.Drawing.Size(75, 23);
            this.SearchErrorListButton.TabIndex = 3;
            this.SearchErrorListButton.Text = "検索";
            this.SearchErrorListButton.UseVisualStyleBackColor = true;
            // 
            // ErrorDataGridView
            // 
            this.ErrorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ErrorDataGridView.MultiSelect = false;
            this.ErrorDataGridView.Name = "ErrorDataGridView";
            this.ErrorDataGridView.RowTemplate.Height = 21;
            this.ErrorDataGridView.Size = new System.Drawing.Size(540, 366);
            this.ErrorDataGridView.TabIndex = 4;
            // 
            // SelectedItemDataGrid
            // 
            this.SelectedItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedItemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemDataGrid.Location = new System.Drawing.Point(0, 0);
            this.SelectedItemDataGrid.Name = "SelectedItemDataGrid";
            this.SelectedItemDataGrid.RowTemplate.Height = 21;
            this.SelectedItemDataGrid.Size = new System.Drawing.Size(256, 421);
            this.SelectedItemDataGrid.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SelectedItemDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(800, 421);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.IdTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.SearchErrorListButton);
            this.splitContainer3.Panel1.Controls.Add(this.KeyNumberLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ErrorDataGridView);
            this.splitContainer3.Size = new System.Drawing.Size(540, 421);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 450);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemErrorAggregationLink,
            this.MenuItemHistoriyReferenceLink});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // MenuItemErrorAggregationLink
            // 
            this.MenuItemErrorAggregationLink.Name = "MenuItemErrorAggregationLink";
            this.MenuItemErrorAggregationLink.Size = new System.Drawing.Size(180, 22);
            this.MenuItemErrorAggregationLink.Text = "エラー集計";
            // 
            // MenuItemHistoriyReferenceLink
            // 
            this.MenuItemHistoriyReferenceLink.Name = "MenuItemHistoriyReferenceLink";
            this.MenuItemHistoriyReferenceLink.Size = new System.Drawing.Size(180, 22);
            this.MenuItemHistoriyReferenceLink.Text = "履歴参照";
            // 
            // ErrorListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "ErrorListView";
            this.Text = "ErrorListView";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedItemDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label KeyNumberLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button SearchErrorListButton;
        private System.Windows.Forms.DataGridView ErrorDataGridView;
        private System.Windows.Forms.DataGridView SelectedItemDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemErrorAggregationLink;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHistoriyReferenceLink;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}