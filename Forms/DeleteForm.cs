﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneCarti.Forms
{
    public partial class DeleteForm : Form
    {

        private OracleConnection connection;
        public DeleteForm(OracleConnection _connection)
        {
            connection = _connection;
            InitializeComponent();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            queryOutput_lbl.Text = string.Empty;
            error_timer.Stop();
        }
        private void del1_ck_CheckedChanged(object? sender, EventArgs e)
        {

            delmore_ck.CheckedChanged -= delmore_ck_CheckedChanged;
            delmore_ck.Checked = false;
            delmore_ck.CheckedChanged += delmore_ck_CheckedChanged;

            single_lbl.Text = "Introdu ID-ul Cărții";
            single_lbl.Show();
            range1_txt.Hide();
            range2_txt.Hide();
            multi_lbl.Hide();
            range_lbl.Hide();
            id_carte_txt.Show();
        }

        private void delmore_ck_CheckedChanged(object? sender, EventArgs e)
        {
            del1_ck.CheckedChanged -= del1_ck_CheckedChanged; // Dezactivează evenimentul
            del1_ck.Checked = false;
            del1_ck.CheckedChanged += del1_ck_CheckedChanged; // Reatașează evenimentul


            multi_lbl.Show();
            single_lbl.Hide();
            range_lbl.Show();
            range1_txt.Show();
            range2_txt.Show();
            id_carte_txt.Hide();
            del1_ck.Checked = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string id_carte = id_carte_txt.Text;

            if (connection.State != ConnectionState.Open)
            {
                queryOutput_lbl.Text = "Conexiune eșuată!";
                error_timer.Start();
            }  

            try
            {
                if (del1_ck.Checked)
                {
                    if (id_carte_txt.Text == string.Empty) throw new CustomException("Concretizați ID-ul cărții");
                    string query = "DELETE FROM CARTI WHERE ID_CARTE = :id_carte";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":id_carte", OracleDbType.Int32).Value = Convert.ToInt32(id_carte_txt.Text);
                        cmd.ExecuteNonQuery();
                        queryOutput_lbl.Text = $"Cartea ID-{id_carte} a fost ștearsă cu succes!";
                        error_timer.Start();
                    }
                }

                if (delmore_ck.Checked) // Decomentează dacă este necesar
                {
                    if (range1_txt.Text == string.Empty && range2_txt.Text == string.Empty) throw new CustomException("Concretizați intervalele ID-urilor");
                    string query = "DELETE FROM CARTI WHERE ID_CARTE BETWEEN :id_range1 AND :id_range2";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":id_range1", OracleDbType.Int32).Value = Convert.ToInt32(range1_txt.Text);
                        cmd.Parameters.Add(":id_range2", OracleDbType.Int32).Value = Convert.ToInt32(range2_txt.Text);

                        int rows = cmd.ExecuteNonQuery();
                        queryOutput_lbl.Text = $"Au fost șterse {rows} cărți!";
                        error_timer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Commit();
                queryOutput_lbl.Text = "Modificări salvate!";
                error_timer.Start();
            } else
            {
                queryOutput_lbl.Text = "Conxiune eșuată!";
                error_timer.Start();
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            error_timer.Tick += Timer_Tick;
        }
    }
}
