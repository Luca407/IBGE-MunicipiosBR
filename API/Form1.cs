using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var mun = await Municipios.BuscarMunicipios();

            listView1.Items.Clear();

            foreach (var m in mun)
            {
                var item = new ListViewItem(m.Id.ToString());
                item.SubItems.Add(m.Nome ?? "");
                item.SubItems.Add(m.Microregiao?.Mesoregiao?.Uf?.Sigla ?? "");
                item.SubItems.Add(m.Microregiao?.Mesoregiao?.Uf?.Regiao?.Sigla ?? "");

                listView1.Items.Add(item);
            }

            
        }
    }
}
