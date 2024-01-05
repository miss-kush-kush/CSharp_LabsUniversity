using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakturaForms.DataContext;

namespace FakturaForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            UpdateFaktura();
        }

        private void UpdateFaktura()
        {
            if (!string.IsNullOrWhiteSpace(Id_txt.Text))
            {
                try
                {
                    decimal id = decimal.Parse(Id_txt.Text);
                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var faktura = context.Faktury.FirstOrDefault(f => f.FakturaId == id);
                                if (faktura != null)
                                {
                                    if (!string.IsNullOrWhiteSpace(Numer_txt.Text))
                                    {
                                        faktura.Numer = Numer_txt.Text;
                                    }

                                    context.SaveChanges();
                                    transaction.Commit();
                                    MessageBox.Show("Faktura updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Faktura not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Faktura ID provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PozUpdate_btn_Click(object sender, EventArgs e)
        {
            UpdatePozycja();
        }

        private void UpdatePozycja()
        {
            if (!string.IsNullOrWhiteSpace(PozId_txt.Text))
            {
                try
                {
                    decimal pozId = decimal.Parse(PozId_txt.Text);
                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var pozycja = context.Pozycje.FirstOrDefault(p => p.PozycjaId == pozId);
                                if (pozycja != null)
                                {
                                    if (!string.IsNullOrWhiteSpace(Nazwa_txt.Text))
                                    {
                                        pozycja.Nazwa = Nazwa_txt.Text;
                                    }

                                    if (!string.IsNullOrWhiteSpace(FakId_txt.Text))
                                    {
                                        decimal fakturaId = decimal.Parse(FakId_txt.Text);
                                        pozycja.FakturaId = fakturaId;
                                    }

                                    if (!string.IsNullOrWhiteSpace(Wartosc_txt.Text))
                                    {
                                        decimal wartosc = decimal.Parse(Wartosc_txt.Text);
                                        pozycja.Wartosc = wartosc;
                                    }

                                    context.SaveChanges();
                                    transaction.Commit();
                                    MessageBox.Show("Pozycja updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Pozycja not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Pozycja ID provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
