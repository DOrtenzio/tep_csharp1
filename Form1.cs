using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1 { //package
    public partial class Form1 : Form { //Classe parziale su più file, che estende Form ovvero una gui
        private int contatore;
        public Form1() {  //costruttore
            InitializeComponent(); //scene inizialize
            this.contatore = 0;
        }

        protected void increment() { 
            this.contatore++;
            writeOnLabel();
        }
        protected void decrement() { 
            this.contatore--;
            writeOnLabel();
        }
        protected void reset() { 
            this.contatore=0;
            writeOnLabel();
        }

        private void writeOnLabel(){ lblCounter.Text = contatore.ToString(); }

        //Handler o metodi collegati ad eventi
        private void btn_increment(object sender, EventArgs e) {
            this.increment();
        }

        private void btn_decrement(object sender, EventArgs e) {
            this.decrement();
        }

        private void btn_reset(object sender, EventArgs e) {
            this.reset();
        }
    }
}
