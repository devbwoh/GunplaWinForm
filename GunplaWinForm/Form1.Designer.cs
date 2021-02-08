
namespace GunplaWinForm {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.gridMechanic = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textArmor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(828, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "데이터베이스 접속";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridMechanic
            // 
            this.gridMechanic.AllowUserToAddRows = false;
            this.gridMechanic.AllowUserToDeleteRows = false;
            this.gridMechanic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMechanic.Location = new System.Drawing.Point(299, 12);
            this.gridMechanic.Name = "gridMechanic";
            this.gridMechanic.ReadOnly = true;
            this.gridMechanic.RowHeadersWidth = 62;
            this.gridMechanic.RowTemplate.Height = 30;
            this.gridMechanic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMechanic.Size = new System.Drawing.Size(828, 497);
            this.gridMechanic.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textArmor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textManufacturer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 551);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mechanic 데이터";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(10, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(234, 28);
            this.textName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(10, 140);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(234, 28);
            this.textModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manufacturer";
            // 
            // textManufacturer
            // 
            this.textManufacturer.Location = new System.Drawing.Point(10, 214);
            this.textManufacturer.Name = "textManufacturer";
            this.textManufacturer.Size = new System.Drawing.Size(234, 28);
            this.textManufacturer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Armor";
            // 
            // textArmor
            // 
            this.textArmor.Location = new System.Drawing.Point(10, 292);
            this.textArmor.Name = "textArmor";
            this.textArmor.Size = new System.Drawing.Size(234, 28);
            this.textArmor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Height";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(10, 370);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(234, 28);
            this.textHeight.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weight";
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(23, 454);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(234, 28);
            this.textWeight.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(237, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAdd);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 576);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridMechanic);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mechanic";
            ((System.ComponentModel.ISupportInitialize)(this.gridMechanic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridMechanic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textArmor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textManufacturer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textWeight;
    }
}

