using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitABit
{
    public partial class Form1 : Form
    {
        private Lampada lam;
        public Form1()
        {
            InitializeComponent();
            lam = new Lampada();
            atualizar();
        }
        public void atualizar() 
        {
            lbldecimal.Text = Convert.ToString(lam.getEstado()).PadLeft(3,'0');
            lblbinario.Text = Convert.ToString(lam.getEstado(), 2).PadLeft(8, '0');
            lblhexa.Text = Convert.ToString(lam.getEstado(), 16).ToUpper().PadLeft(2, '0');

            picLampada1.Image = (lam.getEstado(1)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada2.Image = (lam.getEstado(2)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada3.Image = (lam.getEstado(3)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada4.Image = (lam.getEstado(4)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada5.Image = (lam.getEstado(5)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada6.Image = (lam.getEstado(6)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada7.Image = (lam.getEstado(7)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;
            picLampada8.Image = (lam.getEstado(8)) ? BitABit.Properties.Resources.LampadaAcesa : BitABit.Properties.Resources.LampadaApagada;

            chb1.Checked = lam.getEstado(1);
            chb2.Checked = lam.getEstado(2);
            chb3.Checked = lam.getEstado(3);
            chb4.Checked = lam.getEstado(4);
            chb5.Checked = lam.getEstado(5);
            chb6.Checked = lam.getEstado(6);
            chb7.Checked = lam.getEstado(7);
            chb8.Checked = lam.getEstado(8);
        }
 

        private void EstadoMudança(object sender, EventArgs e)
        {
            int valor;
            CheckBox remetente = (CheckBox)sender;
            valor = int.Parse(remetente.Tag.ToString());
            if (remetente.Checked)
            {
                lam.acender(valor);
            }
            else
            {
                lam.apagar(valor);
            }
            atualizar();
        }
    }
    }

