namespace HW1_automation
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
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_token = new System.Windows.Forms.Label();
            this.lbl_label = new System.Windows.Forms.Label();
            this.txt_box_proj = new System.Windows.Forms.TextBox();
            this.txt_box_token = new System.Windows.Forms.TextBox();
            this.txt_box_label = new System.Windows.Forms.TextBox();
            this.btn_run_cmd = new System.Windows.Forms.Button();
            this.txt_box_error = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_test_name = new System.Windows.Forms.Label();
            this.txt_box_name = new System.Windows.Forms.TextBox();
            this.lbl_test_id = new System.Windows.Forms.Label();
            this.txt_box_id = new System.Windows.Forms.TextBox();
            this.lbl_config = new System.Windows.Forms.Label();
            this.txt_box_config = new System.Windows.Forms.TextBox();
            this.lbl_report = new System.Windows.Forms.Label();
            this.txt_box_report = new System.Windows.Forms.TextBox();
            this.lbl_mandatory = new System.Windows.Forms.Label();
            this.lbl_optional = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Location = new System.Drawing.Point(12, 62);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(52, 17);
            this.lbl_project.TabIndex = 0;
            this.lbl_project.Text = "Project";
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Location = new System.Drawing.Point(11, 89);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(48, 17);
            this.lbl_token.TabIndex = 1;
            this.lbl_token.Text = "Token";
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Location = new System.Drawing.Point(12, 116);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(43, 17);
            this.lbl_label.TabIndex = 2;
            this.lbl_label.Text = "Label";
            // 
            // txt_box_proj
            // 
            this.txt_box_proj.Location = new System.Drawing.Point(70, 62);
            this.txt_box_proj.Name = "txt_box_proj";
            this.txt_box_proj.Size = new System.Drawing.Size(291, 22);
            this.txt_box_proj.TabIndex = 3;
            this.txt_box_proj.Text = "ureGGMth";
            // 
            // txt_box_token
            // 
            this.txt_box_token.Location = new System.Drawing.Point(70, 89);
            this.txt_box_token.Name = "txt_box_token";
            this.txt_box_token.Size = new System.Drawing.Size(291, 22);
            this.txt_box_token.TabIndex = 4;
            this.txt_box_token.Text = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ2IjowLCJkIjp7InVpZCI6ImNpOnVyZUdHTXRoIiwi" +
    "ZW1haWwiOiJyYW1pZGFnYW5AeWFob28uY29tIn0sImlhdCI6MTQ4NTYwOTMwNn0.4UUN529Z2pmPUGtx" +
    "bMDlalqh-1ygbCupWpTDYG_S7-4";
            // 
            // txt_box_label
            // 
            this.txt_box_label.Location = new System.Drawing.Point(70, 117);
            this.txt_box_label.Name = "txt_box_label";
            this.txt_box_label.Size = new System.Drawing.Size(291, 22);
            this.txt_box_label.TabIndex = 5;
            this.txt_box_label.Text = "ant";
            // 
            // btn_run_cmd
            // 
            this.btn_run_cmd.Location = new System.Drawing.Point(15, 169);
            this.btn_run_cmd.Name = "btn_run_cmd";
            this.btn_run_cmd.Size = new System.Drawing.Size(75, 35);
            this.btn_run_cmd.TabIndex = 6;
            this.btn_run_cmd.Text = "Run Test";
            this.btn_run_cmd.UseVisualStyleBackColor = true;
            this.btn_run_cmd.Click += new System.EventHandler(this.btn_run_cmd_Click);
            // 
            // txt_box_error
            // 
            this.txt_box_error.Location = new System.Drawing.Point(15, 234);
            this.txt_box_error.Multiline = true;
            this.txt_box_error.Name = "txt_box_error";
            this.txt_box_error.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_box_error.Size = new System.Drawing.Size(689, 373);
            this.txt_box_error.TabIndex = 7;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(12, 214);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(84, 17);
            this.lbl_result.TabIndex = 8;
            this.lbl_result.Text = "Test Result:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(121, 214);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(195, 17);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Running test(s), please wait...";
            // 
            // lbl_test_name
            // 
            this.lbl_test_name.AutoSize = true;
            this.lbl_test_name.Location = new System.Drawing.Point(377, 63);
            this.lbl_test_name.Name = "lbl_test_name";
            this.lbl_test_name.Size = new System.Drawing.Size(78, 17);
            this.lbl_test_name.TabIndex = 10;
            this.lbl_test_name.Text = "Test-Name";
            // 
            // txt_box_name
            // 
            this.txt_box_name.Location = new System.Drawing.Point(461, 61);
            this.txt_box_name.Name = "txt_box_name";
            this.txt_box_name.Size = new System.Drawing.Size(216, 22);
            this.txt_box_name.TabIndex = 11;
            // 
            // lbl_test_id
            // 
            this.lbl_test_id.AutoSize = true;
            this.lbl_test_id.Location = new System.Drawing.Point(377, 94);
            this.lbl_test_id.Name = "lbl_test_id";
            this.lbl_test_id.Size = new System.Drawing.Size(54, 17);
            this.lbl_test_id.TabIndex = 12;
            this.lbl_test_id.Text = "Test-ID";
            // 
            // txt_box_id
            // 
            this.txt_box_id.Location = new System.Drawing.Point(462, 91);
            this.txt_box_id.Name = "txt_box_id";
            this.txt_box_id.Size = new System.Drawing.Size(216, 22);
            this.txt_box_id.TabIndex = 13;
            // 
            // lbl_config
            // 
            this.lbl_config.AutoSize = true;
            this.lbl_config.Location = new System.Drawing.Point(377, 124);
            this.lbl_config.Name = "lbl_config";
            this.lbl_config.Size = new System.Drawing.Size(75, 17);
            this.lbl_config.TabIndex = 14;
            this.lbl_config.Text = "Config-File";
            // 
            // txt_box_config
            // 
            this.txt_box_config.Location = new System.Drawing.Point(463, 121);
            this.txt_box_config.Name = "txt_box_config";
            this.txt_box_config.Size = new System.Drawing.Size(216, 22);
            this.txt_box_config.TabIndex = 15;
            // 
            // lbl_report
            // 
            this.lbl_report.AutoSize = true;
            this.lbl_report.Location = new System.Drawing.Point(380, 152);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Size = new System.Drawing.Size(78, 17);
            this.lbl_report.TabIndex = 16;
            this.lbl_report.Text = "Report-File";
            // 
            // txt_box_report
            // 
            this.txt_box_report.Location = new System.Drawing.Point(463, 150);
            this.txt_box_report.Name = "txt_box_report";
            this.txt_box_report.Size = new System.Drawing.Size(216, 22);
            this.txt_box_report.TabIndex = 17;
            // 
            // lbl_mandatory
            // 
            this.lbl_mandatory.AutoSize = true;
            this.lbl_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_mandatory.Location = new System.Drawing.Point(15, 13);
            this.lbl_mandatory.Name = "lbl_mandatory";
            this.lbl_mandatory.Size = new System.Drawing.Size(89, 17);
            this.lbl_mandatory.TabIndex = 18;
            this.lbl_mandatory.Text = "Mandatory:";
            // 
            // lbl_optional
            // 
            this.lbl_optional.AutoSize = true;
            this.lbl_optional.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_optional.Location = new System.Drawing.Point(377, 13);
            this.lbl_optional.Name = "lbl_optional";
            this.lbl_optional.Size = new System.Drawing.Size(74, 17);
            this.lbl_optional.TabIndex = 19;
            this.lbl_optional.Text = "Optional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "(Working example is allready filled, feel free to edit)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_optional);
            this.Controls.Add(this.lbl_mandatory);
            this.Controls.Add(this.txt_box_report);
            this.Controls.Add(this.lbl_report);
            this.Controls.Add(this.txt_box_config);
            this.Controls.Add(this.lbl_config);
            this.Controls.Add(this.txt_box_id);
            this.Controls.Add(this.lbl_test_id);
            this.Controls.Add(this.txt_box_name);
            this.Controls.Add(this.lbl_test_name);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_box_error);
            this.Controls.Add(this.btn_run_cmd);
            this.Controls.Add(this.txt_box_label);
            this.Controls.Add(this.txt_box_token);
            this.Controls.Add(this.txt_box_proj);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.lbl_project);
            this.Name = "Form1";
            this.Text = "Testim.io AUTORUN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.Label lbl_label;
        private System.Windows.Forms.TextBox txt_box_proj;
        private System.Windows.Forms.TextBox txt_box_token;
        private System.Windows.Forms.TextBox txt_box_label;
        private System.Windows.Forms.Button btn_run_cmd;
        private System.Windows.Forms.TextBox txt_box_error;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_test_name;
        private System.Windows.Forms.TextBox txt_box_name;
        private System.Windows.Forms.Label lbl_test_id;
        private System.Windows.Forms.TextBox txt_box_id;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.TextBox txt_box_config;
        private System.Windows.Forms.Label lbl_report;
        private System.Windows.Forms.TextBox txt_box_report;
        private System.Windows.Forms.Label lbl_mandatory;
        private System.Windows.Forms.Label lbl_optional;
        private System.Windows.Forms.Label label1;
    }
}

