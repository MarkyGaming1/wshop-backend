using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; // <-- Fontos az Async-hez!

namespace wshop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // --- 1. Adatok betöltése (6. Követelmény: Aszinkron) ---
        private async Task LoadProducts(string searchTerm = "")
        {
            try
            {
                using (MagazinDbContext db = new MagazinDbContext())
                {
                    var query = db.Produse.AsQueryable();

                    // 3. Követelmény: Szűrés (keresés)
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        string lowerSearchTerm = searchTerm.ToLower();
                        query = query.Where(p =>
                            p.ProductName.ToLower().Contains(lowerSearchTerm) ||
                            p.ProductDescription.ToLower().Contains(lowerSearchTerm)
                        );
                    }

                    // 6. Követelmény: Aszinkron betöltés
                    var productList = await query.ToListAsync();

                    // 6. Követelmény: Az eredmény visszaadása a GUI szálnak (Invoke)
                    dataGridViewProduse.DataSource = productList;

                    // Oszlopok átnevezése (ha léteznek)
                    if (dataGridViewProduse.Columns["Id"] != null)
                    {
                        dataGridViewProduse.Columns["Id"].HeaderText = "Azonosító";
                        dataGridViewProduse.Columns["ProductName"].HeaderText = "Terméknév";
                        dataGridViewProduse.Columns["ProductDescription"].HeaderText = "Leírás";
                        dataGridViewProduse.Columns["Intrare"].HeaderText = "Beérkezés";
                        dataGridViewProduse.Columns["Valabil"].HeaderText = "Lejárat";
                        dataGridViewProduse.Columns["Cant"].HeaderText = "Mennyiség";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatok betöltése közben: " + ex.Message);
            }
        }

        // --- 2. Form betöltődése (Async) ---
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadProducts(); // Azonnal töltsük be az adatokat induláskor
        }

        // --- 3. Refresh gomb (Async) ---
        // (A gomb neve a Designer-ben legyen 'btnRefresh')
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (Controls.Find("txtCauta", true).FirstOrDefault() is TextBox txtCauta)
            {
                txtCauta.Text = "";
            }
            await LoadProducts(); // Töltsük be újra az összes terméket
        }

        // --- 4. Kereső TextBox eseménye (Async) ---
        // (A TextBox neve a Designer-ben legyen 'txtCauta')
        private async void txtCauta_TextChanged(object sender, EventArgs e)
        {
            await LoadProducts((sender as TextBox).Text);
        }

        // --- 5. Menüpont: Új Termék (Async) ---
        // (4. Követelmény)
        private async void adaugareProdusNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog(); // Megvárjuk, amíg bezárul

            // Frissítjük a rácsot
            await LoadProducts(Controls.Find("txtCauta", true).FirstOrDefault()?.Text ?? "");
        }

        // --- 6. Menüpont: Mennyiség Hozzáadása (Async) ---
        // (4. Követelmény)
        private async void adaugareCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuantityForm qtyForm = new AddQuantityForm();
            qtyForm.ShowDialog(); // Megvárjuk, amíg bezárul

            // Frissítjük a rácsot
            await LoadProducts(Controls.Find("txtCauta", true).FirstOrDefault()?.Text ?? "");
        }

        // --- 7. Dupla kattintás a rácson (Eladás) (Async) ---
        // (5. Követelmény)
        private async void dataGridViewProduse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Fejléc-re kattintva ne csináljon semmit

            try
            {
                int selectedId = (int)dataGridViewProduse.Rows[e.RowIndex].Cells["Id"].Value;

                Produs produsDeVandut;
                using (var db = new MagazinDbContext())
                {
                    // Aszinkron termékkeresés
                    produsDeVandut = await db.Produse.FindAsync(selectedId);
                }

                if (produsDeVandut != null)
                {
                    SellProductForm sellForm = new SellProductForm(produsDeVandut);
                    sellForm.ShowDialog(); // Megvárjuk, amíg bezárul

                    // Frissítjük a rácsot (a szűrés megtartásával)
                    await LoadProducts(Controls.Find("txtCauta", true).FirstOrDefault()?.Text ?? "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a termék kiválasztásakor: " + ex.Message);
            }
        }

        // Üres eseménykezelők, amiket a user korábbi kódja tartalmazott
        private void dataGridViewProduse_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void vanzareProduseToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void cautareProduseToolStripMenuItem_Click(object sender, EventArgs e) { }

       
    }
}