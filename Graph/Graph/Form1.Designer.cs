
namespace Graph
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
            this.nodeButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.adjacentLabel = new System.Windows.Forms.Label();
            this.nodeTextBox = new System.Windows.Forms.TextBox();
            this.edge1TextBox = new System.Windows.Forms.TextBox();
            this.nodeLabel = new System.Windows.Forms.Label();
            this.edgeLabel = new System.Windows.Forms.Label();
            this.adjacent1TextBox = new System.Windows.Forms.TextBox();
            this.adjacentButton = new System.Windows.Forms.Button();
            this.yesNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adjacent2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edge2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nodeButton
            // 
            this.nodeButton.Location = new System.Drawing.Point(30, 74);
            this.nodeButton.Name = "nodeButton";
            this.nodeButton.Size = new System.Drawing.Size(90, 23);
            this.nodeButton.TabIndex = 0;
            this.nodeButton.Text = "Insert Node";
            this.nodeButton.UseVisualStyleBackColor = true;
            this.nodeButton.Click += new System.EventHandler(this.nodeButton_Click);
            // 
            // edgeButton
            // 
            this.edgeButton.Location = new System.Drawing.Point(171, 98);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(115, 23);
            this.edgeButton.TabIndex = 1;
            this.edgeButton.Text = "Insert Directed Edge";
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(28, 157);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(165, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display Total Number of Nodes:";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(199, 159);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(77, 20);
            this.countTextBox.TabIndex = 3;
            // 
            // adjacentLabel
            // 
            this.adjacentLabel.AutoSize = true;
            this.adjacentLabel.Location = new System.Drawing.Point(350, 32);
            this.adjacentLabel.Name = "adjacentLabel";
            this.adjacentLabel.Size = new System.Drawing.Size(94, 13);
            this.adjacentLabel.TabIndex = 4;
            this.adjacentLabel.Text = "Adjacency Check:";
            // 
            // nodeTextBox
            // 
            this.nodeTextBox.Location = new System.Drawing.Point(30, 48);
            this.nodeTextBox.Name = "nodeTextBox";
            this.nodeTextBox.Size = new System.Drawing.Size(77, 20);
            this.nodeTextBox.TabIndex = 5;
            // 
            // edge1TextBox
            // 
            this.edge1TextBox.Location = new System.Drawing.Point(221, 48);
            this.edge1TextBox.Name = "edge1TextBox";
            this.edge1TextBox.Size = new System.Drawing.Size(77, 20);
            this.edge1TextBox.TabIndex = 6;
            // 
            // nodeLabel
            // 
            this.nodeLabel.AutoSize = true;
            this.nodeLabel.Location = new System.Drawing.Point(27, 32);
            this.nodeLabel.Name = "nodeLabel";
            this.nodeLabel.Size = new System.Drawing.Size(104, 13);
            this.nodeLabel.TabIndex = 7;
            this.nodeLabel.Text = "Node to be Inserted:";
            // 
            // edgeLabel
            // 
            this.edgeLabel.AutoSize = true;
            this.edgeLabel.Location = new System.Drawing.Point(168, 32);
            this.edgeLabel.Name = "edgeLabel";
            this.edgeLabel.Size = new System.Drawing.Size(146, 13);
            this.edgeLabel.TabIndex = 8;
            this.edgeLabel.Text = "Directed Edge to be Inserted:";
            // 
            // adjacent1TextBox
            // 
            this.adjacent1TextBox.Location = new System.Drawing.Point(401, 48);
            this.adjacent1TextBox.Name = "adjacent1TextBox";
            this.adjacent1TextBox.Size = new System.Drawing.Size(77, 20);
            this.adjacent1TextBox.TabIndex = 9;
            // 
            // adjacentButton
            // 
            this.adjacentButton.Location = new System.Drawing.Point(345, 98);
            this.adjacentButton.Name = "adjacentButton";
            this.adjacentButton.Size = new System.Drawing.Size(90, 23);
            this.adjacentButton.TabIndex = 10;
            this.adjacentButton.Text = "Adjacent or not";
            this.adjacentButton.UseVisualStyleBackColor = true;
            this.adjacentButton.Click += new System.EventHandler(this.adjacentButton_Click);
            // 
            // yesNoTextBox
            // 
            this.yesNoTextBox.Location = new System.Drawing.Point(441, 100);
            this.yesNoTextBox.Name = "yesNoTextBox";
            this.yesNoTextBox.Size = new System.Drawing.Size(37, 20);
            this.yesNoTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Node m:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Node n:";
            // 
            // adjacent2TextBox
            // 
            this.adjacent2TextBox.Location = new System.Drawing.Point(401, 71);
            this.adjacent2TextBox.Name = "adjacent2TextBox";
            this.adjacent2TextBox.Size = new System.Drawing.Size(77, 20);
            this.adjacent2TextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Node m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Node n:";
            // 
            // edge2TextBox
            // 
            this.edge2TextBox.Location = new System.Drawing.Point(221, 71);
            this.edge2TextBox.Name = "edge2TextBox";
            this.edge2TextBox.Size = new System.Drawing.Size(77, 20);
            this.edge2TextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 205);
            this.Controls.Add(this.edge2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adjacent2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yesNoTextBox);
            this.Controls.Add(this.adjacentButton);
            this.Controls.Add(this.adjacent1TextBox);
            this.Controls.Add(this.edgeLabel);
            this.Controls.Add(this.nodeLabel);
            this.Controls.Add(this.edge1TextBox);
            this.Controls.Add(this.nodeTextBox);
            this.Controls.Add(this.adjacentLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.nodeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nodeButton;
        private System.Windows.Forms.Button edgeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label adjacentLabel;
        private System.Windows.Forms.TextBox nodeTextBox;
        private System.Windows.Forms.TextBox edge1TextBox;
        private System.Windows.Forms.Label nodeLabel;
        private System.Windows.Forms.Label edgeLabel;
        private System.Windows.Forms.TextBox adjacent1TextBox;
        private System.Windows.Forms.Button adjacentButton;
        private System.Windows.Forms.TextBox yesNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adjacent2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edge2TextBox;
    }
}

