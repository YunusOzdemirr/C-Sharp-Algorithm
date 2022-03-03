using System;

namespace Algorithms
{
    public class Calculate
    {

    }
    public partial class Form1
    {
        String[] urunler = { "defter - ", "cetvel - ", "pergel - ", "kalem - ", "silgi - ", "NotDeteri - " };
        double[] urunler2 = { 4.99, 1.99, 2.99, 1.49, 0.39, 3.79 };
        double toplam = 0;

        // public Form1()
        // {
        //     InitializeComponent();
        // }

        private void Form1_Load(object sender, EventArgs e)
        {
            addUrun();
            ValueAdd();
        }

        private void addUrun()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                UrnList.Items.Add(urunler[i] + urunler2[i] + " TL ");
            }
        }
        private void ValueAdd()
        {
            for (int i = 0; i < UrnList.Items.Count; i++)
            {
                UrnList.SelectedValue = urunler2[i];
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FiyatList.Items.Add(UrnList.SelectedItem);
            UrnList.Items.Remove(UrnList.SelectedItem);
        }

        private void exBtn_Click(object sender, EventArgs e)
        {
            UrnList.Items.Add(FiyatList.SelectedItem);
            FiyatList.Items.Remove(FiyatList.SelectedItem);
        }

        private void HesBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < FiyatList.Items.Count; i++)
            {
                toplam += Convert.ToDouble(FiyatList.Items[i]);
            }
            foreach
            ToplamBox.Text = Convert.ToString(toplam);
        }
    }
}