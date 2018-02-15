using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //hide working label
            this.lbl_time.Visible = false;
        }

        private void btn_run_cmd_Click(object sender, EventArgs e)
        {
            
            if (this.txt_box_proj.Text != "" && this.txt_box_token.Text != "" && this.txt_box_label.Text != "")
            {
                this.txt_box_error.Text = "";
                //Get data from user form
                string proj_name = this.txt_box_proj.Text;
                string proj_token = this.txt_box_token.Text;
                string proj_lbl = this.txt_box_label.Text;
                string test_name = this.txt_box_name.Text;
                string test_id = this.txt_box_id.Text;
                string test_config = this.txt_box_config.Text;
                string test_report = this.txt_box_report.Text;

                //show working label
                this.lbl_time.Visible = true;

                //Create a process Start info to set the information
                ProcessStartInfo pro = new ProcessStartInfo();
                //Setting up the Working Directory
                var pathWithEnv = @"%USERPROFILE%\";
                var dir = Environment.ExpandEnvironmentVariables(pathWithEnv);
                pro.WorkingDirectory = dir;

                //setting process start info
                pro.RedirectStandardInput = true;
                pro.RedirectStandardOutput = true;
                pro.UseShellExecute = false;
                pro.CreateNoWindow = true;
                pro.FileName = "cmd.exe";

                //Creating an Instance of the Process Class
                // which will help to execute our Process
                Process proStart = new Process();
                //Setting up the Process Name here which we are
                // going to start from ProcessStartInfo
                proStart.StartInfo = pro;
                //Calling the Start Method of Process class to
                // Invoke our Process via 'cmd.exe'
                proStart.Start();

                //init string
                String s2 = "testim ";


                if (txt_box_name.Text != "")
                {
                    // --name
                    s2 += "--name ";
                    s2 += "\"" + test_name + "\" ";
                }
                else
                {
                    // --label
                    s2 += "--label ";
                    s2 += "\"" + proj_lbl + "\" ";
                }


                // --token
                s2 += "--token ";
                s2 += "\"" + proj_token + "\" ";

                // --project
                s2 += "--project ";
                s2 += "\"" + proj_name + "\" ";

                // --host, --port
                s2 += "--host \"ondemand.testim.io\" --port 4444 ";

                // --report-file
                if (txt_box_report.Text != "")
                {
                    s2 += "--report-file ";
                    s2 += "\"" + test_report + "\" ";
                }


                // --config-file
                if (txt_box_config.Text != "")
                {
                    s2 += "--config - file ";
                    s2 += test_config + " ";
                }

                // --test id
                if (txt_box_id.Text != "")
                {
                    s2 += "--testId ";
                    s2 += "\"" + test_id + "\" ";
                }
                    


                //Write to console
                proStart.StandardInput.WriteLine(s2);

                //Clear input and close input stream
                proStart.StandardInput.Flush();
                proStart.StandardInput.Close();
                proStart.WaitForExit();

                //hide working label
                this.lbl_time.Visible = false;

                //get output from the process (cmd output)
                string output = proStart.StandardOutput.ReadToEnd();

                output = output.Substring(output.IndexOf('>') + 1);
                output = output.Remove(output.LastIndexOf(Environment.NewLine));

                //show outpot in text box
                this.txt_box_error.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("Not all mandatory fields are valid!");
            }
        }

    }
}
