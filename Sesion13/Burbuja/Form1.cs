using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burbuja.models;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        // Arreglo de numeros
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // Agregar el numero al arreglo
            int number = int.Parse(tbNumber.Text);
            numbers[i++] = number;
            showNumbers();
        }
        private void showNumbers()
        {
            // Limpiar la lista
            if (numbers.Length > 0) {
                lbNumbers.Items.Clear();
            }
            // Mostrar los numeros
            for (int i = 0; i < numbers.Length; i++)
            {
                lbNumbers.Items.Add(numbers[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MetBurbuja burbuja = new MetBurbuja();
            burbuja.OrdenarBurbuja(numbers);
            showNumbers();
        }
    }
}
