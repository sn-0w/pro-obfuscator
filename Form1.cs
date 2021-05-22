using dnlib.DotNet;
using dnlib.DotNet.Writer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObfuscatorProject
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    textBox1.Text = openFileDialog1.FileName;
                }
                catch (IOException)
                {
                }
            }

        }

        private void protectbtn_Click(object sender, EventArgs e)
        {
            ModuleDef mod = ModuleDefMD.Load(textBox1.Text);
            if (renamer.Checked == true)
            {
                Protections.Renaming.Renamer.Exec(mod);
            }
            if (StringProtection.Checked == true)
            {
                Protections.StringProtection.stringencrypt.Exec(mod);
            }
            if (StringProtect_2.Checked == true)
            {
                Protections.StringProtect_2.StringProtect.Exec(mod);
            }
            if (Mutation.Checked == true)
            {
                Protections.Mutation.Mutation.Exec(mod);
            }            

            SaveExecutable(mod, textBox1.Text);
        }

        public static void SaveExecutable(ModuleDef module, string path)
        {
            module.Write(path + "-obfuscated.exe", new ModuleWriterOptions(module)
            {
                PEHeadersOptions = { NumberOfRvaAndSizes = 13 },
                Logger = DummyLogger.NoThrowInstance
            });
            MessageBox.Show("Done!\n Saved at: \n " + path + "-obfuscated.exe");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
