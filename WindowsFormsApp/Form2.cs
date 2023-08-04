﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontdailog = new FontDialog();
            DialogResult result=fontdailog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontdailog.Font;

            }


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordailog = new ColorDialog();
            DialogResult result = colordailog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colordailog.Color;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.Filter = "notepad (*.txt)|*.txt|document (*.docx)|*.docx|All files(*.*)|*.*";
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(richTextBox1.Text);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.Filter = "notepad (*.txt)|*.txt|document (*.docx)|*.docx|All files(*.*)|*.*";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                    richTextBox1.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
