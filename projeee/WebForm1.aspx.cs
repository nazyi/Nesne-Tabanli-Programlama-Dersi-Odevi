using classes;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projeee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Çanta")//Adjust
            {
                az.Visible = true;
                yeto.Visible = false;
                ofua.Visible = false;
                yavru.Visible = false;
                mark.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Kalem")
            {
                yeto.Visible = true;
                az.Visible = false;
                ofua.Visible = false;
                yavru.Visible = false;
                mark.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Silgi")
            {
                ofua.Visible = true;
                yeto.Visible = false;
                az.Visible = false;
                yavru.Visible = false;
                mark.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Defter")
            {
                ofua.Visible = false;
                yeto.Visible = false;
                az.Visible = false;
                yavru.Visible = true;
                mark.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Kalem Kutu")
            {
                ofua.Visible = false;
                yeto.Visible = false;
                az.Visible = false;
                yavru.Visible = false;
                mark.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Seçiniz")
            {
                ofua.Visible = false;
                yeto.Visible = false;
                az.Visible = false;
                yavru.Visible = false;
                mark.Visible = false;
            }

        }

        public void Main()
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lste.Items.Clear();
            if (DropDownList1.SelectedValue == "Çanta")
            {
                çanta canta = new çanta();
                canta.isim = TextBox1.Text;
                canta.soyad = TextBox2.Text;
                canta.renk = TextBox3.Text;
                canta.Miktar = Int32.Parse(TextBox4.Text);
                canta.bakiye = Int32.Parse(TextBox5.Text);
                canta.canozellik = az.SelectedItem.Text;
                canta.cantalist.Add(canta.isim);
                canta.cantalist.Add(canta.soyad);
                canta.cantalist.Add(canta.renk);
                canta.cantalist.Add(canta.Miktar.ToString());
                canta.cantalist.Add(canta.bakiye.ToString());
                if(canta.bakiye<canta.Miktar*çanta.cantafiyat)
                {
                    lste.Items.Add("bakiyeniz yetersiz");
                }
                else
                {
                    for (int i = 0; i < canta.cantalist.Count; i++)
                    {
                        lste.Items.Add(canta.cantalist.ElementAt(i));
                    }
                }
             }

            if (DropDownList1.SelectedValue == "Kalem")
            {
                kalem kalem1 = new kalem();
                kalem1.isim = TextBox1.Text;
                kalem1.soyad = TextBox2.Text;
                kalem1.renk = TextBox3.Text;
                kalem1.Miktar = Int32.Parse(TextBox4.Text);
                kalem1.bakiye = Int32.Parse(TextBox5.Text);
                kalem1.kalemozellik = yeto.SelectedItem.Text;
                kalem1.kalemlist.Add(kalem1.isim);
                kalem1.kalemlist.Add(kalem1.soyad);
                kalem1.kalemlist.Add(kalem1.renk);
                kalem1.kalemlist.Add(kalem1.Miktar.ToString());
                kalem1.kalemlist.Add(kalem1.bakiye.ToString());
                if (kalem1.bakiye < kalem1.Miktar * kalem.kalemfiyat)
                {
                    lste.Items.Add("bakiyeniz yetersiz");
                }
                else
                {
                    for (int i = 0; i < kalem1.kalemlist.Count; i++)
                    {
                        lste.Items.Add(kalem1.kalemlist.ElementAt(i));
                    }
                }

            }

            if (DropDownList1.SelectedValue == "Silgi")
            {
                Silgi silgi1 = new Silgi();
                silgi1.isim = TextBox1.Text;
                silgi1.soyad = TextBox2.Text;
                silgi1.renk = TextBox3.Text;
                silgi1.Miktar = Int32.Parse(TextBox4.Text);
                silgi1.bakiye = Int32.Parse(TextBox5.Text);
                silgi1.silozellik = ofua.SelectedItem.Text;
                silgi1.silgilist.Add(silgi1.isim);
                silgi1.silgilist.Add(silgi1.soyad);
                silgi1.silgilist.Add(silgi1.renk);
                silgi1.silgilist.Add(silgi1.Miktar.ToString());
                silgi1.silgilist.Add(silgi1.bakiye.ToString());
                if (silgi1.bakiye < silgi1.Miktar * Silgi.silgifiyat)
                {
                    lste.Items.Add("bakiyeniz yetersiz");
                }
                else
                {
                    for (int i = 0; i < silgi1.silgilist.Count; i++)
                    {
                        lste.Items.Add(silgi1.silgilist.ElementAt(i));
                    }
                }

            }

            if (DropDownList1.SelectedValue == "Defter")
            {
                Defter defter1 = new Defter();
                defter1.isim = TextBox1.Text;
                defter1.soyad = TextBox2.Text;
                defter1.renk = TextBox3.Text;
                defter1.Miktar = Int32.Parse(TextBox4.Text);
                defter1.bakiye = Int32.Parse(TextBox5.Text);
                defter1.defozellik = yavru.SelectedItem.Text;
                defter1.defterlist.Add(defter1.isim);
                defter1.defterlist.Add(defter1.soyad);
                defter1.defterlist.Add(defter1.renk);
                defter1.defterlist.Add(defter1.Miktar.ToString());
                defter1.defterlist.Add(defter1.bakiye.ToString());
                if (defter1.bakiye < defter1.Miktar * Defter.defterfiyat)
                {
                    lste.Items.Add("bakiyeniz yetersiz");
                }
                else
                {
                    for (int i = 0; i < defter1.defterlist.Count; i++)
                    {
                        lste.Items.Add(defter1.defterlist.ElementAt(i));
                    }
                }
            }
            if (DropDownList1.SelectedValue == "Kalem Kutu")
            {
                kalemkutu kalkutu1 = new kalemkutu();
                kalkutu1.isim = TextBox1.Text;
                kalkutu1.soyad = TextBox2.Text;
                kalkutu1.renk = TextBox3.Text;
                kalkutu1.Miktar = Int32.Parse(TextBox4.Text);
                kalkutu1.bakiye = Int32.Parse(TextBox5.Text);
                kalkutu1.kalkutuozellik = mark.SelectedItem.Text;
                kalkutu1.kalemkutulist.Add(kalkutu1.isim);
                kalkutu1.kalemkutulist.Add(kalkutu1.soyad);
                kalkutu1.kalemkutulist.Add(kalkutu1.renk+"renk");
                kalkutu1.kalemkutulist.Add(kalkutu1.Miktar.ToString());
                kalkutu1.kalemkutulist.Add(kalkutu1.bakiye.ToString());
                if (kalkutu1.bakiye < kalkutu1.Miktar * kalemkutu.kalemkutufiyat)
                {
                    lste.Items.Add("bakiyeniz yetersiz");
                }
                else
                {
                    for (int i = 0; i < kalkutu1.kalemkutulist.Count; i++)
                    {
                        lste.Items.Add(kalkutu1.kalemkutulist.ElementAt(i));
                    }
                }
            }


        }
    }
}

