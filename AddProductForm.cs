using System;
using System.Windows.Forms;
// Nincs szükség System.Data.Entity-re, mert nem használunk .ToListAsync() vagy .FindAsync()

namespace wshop
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        // A "Hozzáadás" gomb eseménye (Async)
        // (A gomb neve legyen 'button1' vagy 'btnAdauga')
        private async void button1_Click(object sender, EventArgs e)
        {
            // --- 1. Validálás (Adatellenőrzés) ---
            // (Tegyük fel, a TextBox-ok nevei: textBox2-ProductName, textBox3-Description, stb.)

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("A termék neve (ProductName) nem lehet üres!");
                return;
            }

            DateTime dataIntrare;
            if (!DateTime.TryParse(textBox4.Text, out dataIntrare))
            {
                MessageBox.Show("Érvénytelen belépési dátum formátum!");
                return;
            }

            DateTime dataValabilitate;
            if (!DateTime.TryParse(textBox5.Text, out dataValabilitate))
            {
                MessageBox.Show("Érvénytelen szavatossági dátum formátum!");
                return;
            }

            int cantitate;
            if (!int.TryParse(textBox6.Text, out cantitate) || cantitate < 0)
            {
                MessageBox.Show("A mennyiség (Cant) csak pozitív egész szám lehet!");
                return;
            }

            // --- 2. Mentés (ha minden adat érvényes) ---
            try
            {
                using (MagazinDbContext pdb = new MagazinDbContext())
                {
                    Produs p = new Produs
                    {
                        ProductName = textBox2.Text,
                        ProductDescription = textBox3.Text,
                        Intrare = dataIntrare,
                        Valabil = dataValabilitate,
                        Cant = cantitate
                    };

                    pdb.Produse.Add(p);

                    // 6. Követelmény: Aszinkron mentés
                    await pdb.SaveChangesAsync();

                    MessageBox.Show("Produs adaugat cu succes!");

                    // Bezárhatjuk az ablakot, vagy üríthetjük a mezőket
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt mentés közben: " + ex.Message);
            }
        }

        // Üres eseménykezelők, amiket a user korábbi kódja tartalmazott
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}