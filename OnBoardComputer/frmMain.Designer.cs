
namespace OnBoardComputer
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCollections = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCollection = new System.Windows.Forms.Label();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.treeViewData = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCollections
            // 
            this.cmbCollections.FormattingEnabled = true;
            this.cmbCollections.Location = new System.Drawing.Point(67, 102);
            this.cmbCollections.Name = "cmbCollections";
            this.cmbCollections.Size = new System.Drawing.Size(134, 24);
            this.cmbCollections.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(64, 63);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(76, 17);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "INFO ITEM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(480, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 150);
            this.panel1.TabIndex = 3;
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(67, 200);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(110, 17);
            this.lblCollection.TabIndex = 4;
            this.lblCollection.Text = "GENERAL INFO";
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Location = new System.Drawing.Point(502, 89);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(86, 17);
            this.lblGeneralInfo.TabIndex = 5;
            this.lblGeneralInfo.Text = "General Info";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(856, 89);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Position";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(834, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 150);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "HyperSpace Routes";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(480, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 94);
            this.panel3.TabIndex = 10;
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(583, 399);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(487, 257);
            this.picBoxImage.TabIndex = 11;
            this.picBoxImage.TabStop = false;
            // 
            // treeViewData
            // 
            this.treeViewData.Location = new System.Drawing.Point(67, 237);
            this.treeViewData.Name = "treeViewData";
            this.treeViewData.Size = new System.Drawing.Size(121, 290);
            this.treeViewData.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 693);
            this.Controls.Add(this.treeViewData);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblGeneralInfo);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCollections);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCollections;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.TreeView treeViewData;
    }
}

