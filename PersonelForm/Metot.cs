using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonelOtomasyonu
{
    public static class Metot
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;
                else if (item is DateTimePicker)
                    ((DateTimePicker)(item)).Value = DateTime.Now;
                else if (item is PictureBox)
                    ((PictureBox)item).Image = null;
                else if(item is GroupBox)
                    Temizle(((GroupBox)item).Controls);

            }
        }
    }
}
