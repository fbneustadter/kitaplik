﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=kitaplik.mdb");
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            baglanti.Open();
            string sql = "SELECT * FROM kullanicilar WHERE k_adi = '" + textBox1.Text + "' AND parola = '" + textBox2.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.Read()) 
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("YANLIŞ");
                sayac++;
            }
            baglanti.Close();
    
            if(sayac == 5)
            {
                button1.Enabled = false;
            }
        
        
        
        

        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
