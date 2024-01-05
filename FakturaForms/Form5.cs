using FakturaForms.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DeleteFaktura();
        }

        private void DeleteFaktura()
        {
            if (!string.IsNullOrWhiteSpace(IdFak_txt.Text))
            {
                try
                {
                    decimal id = decimal.Parse(IdFak_txt.Text);
                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var faktura = context.Faktury.FirstOrDefault(f => f.FakturaId == id);
                                if (faktura != null)
                                {
                                    context.Faktury.Remove(faktura);
                                    context.SaveChanges();

                                    transaction.Commit();
                                    MessageBox.Show("Faktura deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Faktura not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No Faktura ID provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePoz_btn_Click(object sender, EventArgs e)
        {

            DeletePozycja();
        }

        private void DeletePozycja()
        {
            if (!string.IsNullOrWhiteSpace(IdPoz_txt.Text))
            {
                try
                {
                    decimal id = decimal.Parse(IdPoz_txt.Text);
                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var pozycja = context.Pozycje.FirstOrDefault(f => f.PozycjaId == id);
                                if (pozycja != null)
                                {
                                    context.Pozycje.Remove(pozycja);
                                    context.SaveChanges();

                                    transaction.Commit();
                                    MessageBox.Show("Pozycja deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No Faktura ID provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
