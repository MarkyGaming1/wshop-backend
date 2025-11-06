using System;
using System.Data.Entity; // <-- Fontos a .FindAsync()-hoz
using System.Linq;
using System.Windows.Forms;

namespace wshop
{
    public partial class SellProductForm : Form
    {
        private Produs produsSelectat;

        // 1. Módosított konstruktor: fogadja a terméket
        public SellProductForm(Produs produs)
        {
            InitializeComponent();
            this.produsSelectat = produs;
        }

        // 2. Form betöltődése: Töltsük fel az adatokat
        private void SellProductForm_Load(object sender, EventArgs e)
        {
            // A Designer-ben lévő elemek nevei:
            lblProductName.Text = produsSelectat.ProductName;
            lblCurrentStock.Text = produsSelectat.Cant.ToString();

            // A NumericUpDown neve: numericSellQuantity
            numericSellQuantity.Maximum = produsSelectat.Cant;
            numericSellQuantity.Minimum = 1;
            numericSellQuantity.Value = 1;
        }

        // 3. Eladás gomb (Async)
        // (A gomb neve legyen 'btnVinde')
        private async void btnVinde_Click(object sender, EventArgs e)
        {
            int cantitateDeVandut = (int)numericSellQuantity.Value;

            try
            {
                using (var db = new MagazinDbContext())
                {
                    // 6. Követelmény: Aszinkron keresés (hogy a DbContext kövesse)
                    var produsInDb = await db.Produse.FindAsync(produsSelectat.Id);

                    if (produsInDb == null)
                    {
                        MessageBox.Show("A termék már nem létezik az adatbázisban.");
                        this.Close();
                        return;
                    }

                    // 5. Követelmény: Logika
                    if (produsInDb.Cant < cantitateDeVandut)
                    {
                        MessageBox.Show("Nincs elegendő termék a készleten! (Valaki más közben eladott belőle)");
                        // Frissítjük a max értéket
                        numericSellQuantity.Maximum = produsInDb.Cant;
                        return;
                    }

                    produsInDb.Cant -= cantitateDeVandut;

                    if (produsInDb.Cant == 0)
                    {
                        // 5. Követelmény: Törlés, ha elfogyott
                        db.Produse.Remove(produsInDb);
                        MessageBox.Show($"Sikeres eladás! A termék ('{produsInDb.ProductName}') elfogyott és törölve lett.");
                    }
                    else
                    {
                        MessageBox.Show($"Sikeres eladás! Maradt készleten: {produsInDb.Cant} db.");
                    }

                    // 6. Követelmény: Aszinkron mentés (vagy frissítés, vagy törlés)
                    await db.SaveChangesAsync();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az eladás során: " + ex.Message);
            }
        }
    }
}