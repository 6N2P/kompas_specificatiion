using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kompas6API5;
using KGAXLib;
using Kompas6Constants;
using KompasAPI7;
using KompasTabl;



namespace KompasTabl
{
    public partial class Form1 : Form, IForm1
    {
       

        public Form1()
        {
            InitializeComponent();

        }

#region реализация свойств интерфейса
        public string NameClas
        {
            get => ClasNameTextBox.Text;
            set => ClasNameTextBox.Text = value;
        }
        public int choiseAbstractClas
        {
            get => choiceAbstractionClasComboBox.SelectedIndex;
            set => choiceAbstractionClasComboBox.SelectedIndex = value;
        }
        public int accsesClad
        {
            get => accesClasComboBox.SelectedIndex;
            set => accesClasComboBox.SelectedIndex = value;
        }
        public string NameValue1
        {
            get => ValueTextBox1.Text;
            set => ValueTextBox1.Text = value;
        }
        public int choiseAbstractValue1
        {
            get => choiceAbstractionValueComboBox1.SelectedIndex;
            set => choiceAbstractionValueComboBox1.SelectedIndex = value;
        }
        public int accsesValue1
        {
            get => accessValueComboBox1.SelectedIndex;
            set => accessValueComboBox1.SelectedIndex = value;
        }
        public string NameValue2
        {
            get => ValueTextBox2.Text;
            set => ValueTextBox2.Text = value;
        }
        public int choiseAbstractValue2
        {
            get => choiceAbstractionValueComboBox2.SelectedIndex;
            set => choiceAbstractionValueComboBox2.SelectedIndex = value;
        }
        public int accsesValue2
        {
            get => accessValueComboBox2.SelectedIndex;
            set => accessValueComboBox2.SelectedIndex = value; }
        public string NameValue3
        {
            get => ValueTextBox3.Text;
            set => ValueTextBox3.Text = value; }
        public int choiseAbstractValue3 
        {
            get => choiceAbstractionValueComboBox3.SelectedIndex;
            set => choiceAbstractionValueComboBox3.SelectedIndex = value;
        }
        public int accsesValue3 
        {
            get => accessValueComboBox3.SelectedIndex;
            set => accessValueComboBox3.SelectedIndex = value;
        }
        public string NameValue4
        {
            get => ValueTextBox4.Text;
            set => ValueTextBox4.Text = value;
        }
        public int choiseAbstractValue4
        {
            get => choiceAbstractionValueComboBox4.SelectedIndex;
            set => choiceAbstractionValueComboBox4.SelectedIndex = value;
        }
        public int accsesValue4 
        {
            get => accessValueComboBox4.SelectedIndex;
            set => accessValueComboBox4.SelectedIndex = value;
        }
        public string NameValue5
        {
            get => ValueTextBox5.Text;
            set => ValueTextBox5.Text = value;
        }
        public int choiseAbstractValue5
        {
            get => choiceAbstractionValueComboBox5.SelectedIndex;
            set => choiceAbstractionValueComboBox5.SelectedIndex = value;
        }
        public int accsesValue5 
        {
            get => accessValueComboBox5.SelectedIndex;
            set => accessValueComboBox5.SelectedIndex = value;
        }
        public string NameConstructor1
        {
            get => ConstructorTextBox1.Text;
            set => ConstructorTextBox1.Text = value;
        }
        public int choiseAbstractConstructor1
        {
            get => choiceAbstractionConstructorComboBox1.SelectedIndex;
            set => choiceAbstractionConstructorComboBox1.SelectedIndex = value;
        }
        public int accsesConstructor1
        {
            get => accessConstructorComboBox1.SelectedIndex;
            set => accessConstructorComboBox1.SelectedIndex = value;
        }
        public string NameConstructor2 
        {
            get => ConstructorTextBox2.Text;
            set => ConstructorTextBox2.Text = value;
        }
        public int choiseAbstractConstructor2
        {
            get => choiceAbstractionConstructorComboBox2.SelectedIndex;
            set => choiceAbstractionConstructorComboBox2.SelectedIndex = value;
        }
        public int accsesConstructor2
        {
            get => accessConstructorComboBox2.SelectedIndex;
            set => accessConstructorComboBox2.SelectedIndex = value;
        }
        public string NameConstructor3
        {
            get => ConstructorTextBox3.Text;
            set => ConstructorTextBox3.Text = value;
        }
        public int choiseAbstractConstructor3
        {
            get => choiceAbstractionConstructorComboBox3.SelectedIndex;
            set => choiceAbstractionConstructorComboBox3.SelectedIndex = value;
        }
        public int accsesConstructor3
        {
            get => accessConstructorComboBox3.SelectedIndex;
            set => accessConstructorComboBox3.SelectedIndex = value;
        }
        public string NameInterfeice1 
        {
            get => InterfaceTextBox1.Text;
            set => InterfaceTextBox1.Text = value;
        }
        public int choiseAbstractInterfeice1
        {
            get => choiceAbstractionInterfaceComboBox1.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox1.SelectedIndex = value;
        }
        public int accsesInterfeice1
        {
            get => accessInterfaceComboBox1.SelectedIndex;
            set => accessInterfaceComboBox1.SelectedIndex = value;
        }
        public string NameInterfeice2 
        {
            get => InterfaceTextBox2.Text;
            set => InterfaceTextBox2.Text = value;
        }
        public int choiseAbstractInterfeice2
        {
            get => choiceAbstractionInterfaceComboBox2.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox2.SelectedIndex = value;
        }
        public int accsesInterfeice2 
        {
            get => accessInterfaceComboBox2.SelectedIndex;
            set => accessInterfaceComboBox2.SelectedIndex = value;
        }
        public string NameInterfeice3 
        {
            get => InterfaceTextBox3.Text;
            set => InterfaceTextBox3.Text = value;
        }
        public int choiseAbstractInterfeice3 
        {
            get => choiceAbstractionInterfaceComboBox3.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox3.SelectedIndex = value;
        }
        public int accsesInterfeice3 
        {
            get => accessInterfaceComboBox3.SelectedIndex;
            set => accessInterfaceComboBox3.SelectedIndex = value;
        }
        public string NameInterfeice4 
        {
            get => InterfaceTextBox4.Text;
            set => InterfaceTextBox4.Text = value;
        }
        public int choiseAbstractInterfeice4 
        {
            get => choiceAbstractionInterfaceComboBox4.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox4.SelectedIndex = value;
        }
        public int accsesInterfeice4 
        {
            get => accessInterfaceComboBox4.SelectedIndex;
            set => accessInterfaceComboBox4.SelectedIndex = value;
        }
        public string NameInterfeice5 
        {
            get => InterfaceTextBox5.Text;
            set => InterfaceTextBox5.Text = value;
        }
        public int choiseAbstractInterfeice5
        {
            get => choiceAbstractionInterfaceComboBox5.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox5.SelectedIndex = value;
        }
        public int accsesInterfeice5
        {
            get => accessInterfaceComboBox5.SelectedIndex;
            set => accessInterfaceComboBox5.SelectedIndex = value;
        }
        public string NameInterfeice6 
        {
            get => InterfaceTextBox6.Text;
            set => InterfaceTextBox6.Text = value;
        }
        public int choiseAbstractInterfeice6
        {
            get => choiceAbstractionInterfaceComboBox6.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox6.SelectedIndex = value;
        }
        public int accsesInterfeice6 
        {
            get => accessInterfaceComboBox6.TabIndex;
            set => accessInterfaceComboBox6.TabIndex = value;
        }
        public string NameInterfeice7 
        {
            get => InterfaceTextBox7.Text;
            set => InterfaceTextBox7.Text = value;
        }
        public int choiseAbstractInterfeice7
        {
            get => choiceAbstractionInterfaceComboBox7.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox7.SelectedIndex = value;
        }
        public int accsesInterfeice7
        {
            get => accessInterfaceComboBox7.TabIndex;
            set => accessInterfaceComboBox7.TabIndex = value;
        }
        public string NameInterfeice8 
        {
            get => InterfaceTextBox8.Text;
            set => InterfaceTextBox8.Text = value;
        }
        public int choiseAbstractInterfeice8
        {
            get => choiceAbstractionInterfaceComboBox8.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox8.SelectedIndex = value;
        }
        public int accsesInterfeice8 
        {
            get => accessInterfaceComboBox8.SelectedIndex;
            set => accessInterfaceComboBox8.SelectedIndex = value;
        }
        public string NameInterfeice9
        {
            get => InterfaceTextBox9.Text;
            set => InterfaceTextBox9.Text = value;
        }
        public int choiseAbstractInterfeice9
        {
            get => choiceAbstractionInterfaceComboBox9.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox9.SelectedIndex = value; }
        public int accsesInterfeice9
        {
            get => accessInterfaceComboBox9.SelectedIndex;
            set => accessInterfaceComboBox9.SelectedIndex = value;
        }
        public string NameInterfeice10 
        {
            get => InterfaceTextBox10.Text;
            set => InterfaceTextBox10.Text = value;
        }
        public int choiseAbstractInterfeice10
        {
            get => choiceAbstractionInterfaceComboBox10.SelectedIndex;
            set => choiceAbstractionInterfaceComboBox10.SelectedIndex = value;
        }
        public int accsesInterfeice10
        {
            get => accessInterfaceComboBox10.SelectedIndex;
            set => accessInterfaceComboBox10.SelectedIndex = value;
        }

#endregion реализация свойств интерфейса

        public event EventHandler CreateTabl;

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTabl.Invoke(sender, e);

        }

    }
}
