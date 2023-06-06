using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio
{
    public partial class Form1 : Form
    {

        Alumno alumno1 = new Alumno("", "Alumno 1");
        Alumno alumno2 = new Alumno("", "Alumno 2");
        Alumno alumno3 = new Alumno("", "Alumno 3");
        Alumno alumno4 = new Alumno("", "Alumno 4");
        List<Alumno> alumnos = new List<Alumno>();
        List<string> aula1 = new List<string>();
        List<string> aula2 = new List<string>();
        List<string> aula3 = new List<string>();
        bool crear1 = false, crear2 = false, crear3 = false;
        public Form1()
        {
            InitializeComponent();
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);
        }

        private void btn_CrearColegio_Click(object sender, EventArgs e)
        {
            cbox_Aulas.Items.Add("Aula 1");
            cbox_Aulas.Items.Add("Aula 2");
            cbox_Aulas.Items.Add("Aula 3");
            btn_CrearColegio.Enabled = false;
        }

        private void btn_CrearRelacion_Click(object sender, EventArgs e)
        {

            if (cbox_Aulas.SelectedIndex == 0)
            {
                for (int i = 0; i < alumnos.Count; i++)
                    list_Alumnos.Items.Add(alumnos[i].apellidos);
                for (int i = 0; i < alumnos.Count; i++)
                    aula1.Add(alumnos[i].apellidos);
                crear1 = true;
                btn_CrearRelacion.Enabled = false;
            }
            if (cbox_Aulas.SelectedIndex == 1)
            {
                for (int i = 0; i < alumnos.Count; i++)
                    list_Alumnos.Items.Add(alumnos[i].apellidos);
                for (int i = 0; i < alumnos.Count; i++)
                    aula2.Add(alumnos[i].apellidos);
                crear2 = true;
                btn_CrearRelacion.Enabled = false;
            }
            if (cbox_Aulas.SelectedIndex == 2)
            {
                for (int i = 0; i < alumnos.Count; i++)
                    list_Alumnos.Items.Add(alumnos[i].apellidos);
                for (int i = 0; i < alumnos.Count; i++)
                    aula3.Add(alumnos[i].apellidos);
                crear3 = true;
                btn_CrearRelacion.Enabled = false;
            }
        }

        private void cbox_Aulas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbox_Aulas.SelectedIndex == 0)
            {
                btn_CrearRelacion.Enabled = true;
                if (crear1 == true)
                    btn_CrearRelacion.Enabled = false;
                list_Alumnos.Items.Clear();
                for (int i = 0; i < aula1.Count; i++)
                    list_Alumnos.Items.Add(aula1[i]);
            }
            
            if (cbox_Aulas.SelectedIndex == 1)
            {
                btn_CrearRelacion.Enabled = true;
                if (crear2 == true)
                    btn_CrearRelacion.Enabled = false;
                list_Alumnos.Items.Clear();
                for (int i = 0; i < aula2.Count; i++)
                    list_Alumnos.Items.Add(aula2[i]);
            }
           
            if (cbox_Aulas.SelectedIndex == 2)
            {
                btn_CrearRelacion.Enabled = true;
                if (crear3 == true)
                    btn_CrearRelacion.Enabled = false;
                list_Alumnos.Items.Clear();
                for (int i = 0; i < aula3.Count; i++)
                    list_Alumnos.Items.Add(aula3[i]);
            }
        }
    }
}
