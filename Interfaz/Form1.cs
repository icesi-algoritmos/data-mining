﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using modelo;
using SODA;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        private double rsquared;
        private double yintercept;
        private double slope;
        DataTable dt;
        private String url;
        private String addLink;
        private List<Double> latitudes = new List<Double>();
        private List<Double> longitudes = new List<Double>();
        private List<Double> values = new List<Double>();
        private List<Double> valuesPrediction = new List<double>();
        private List<String> departamentos = new List<string>();
        private List<String> fechas = new List<string>();
        private List<Double> fechasNumbers = new List<double>();
        private List<String> tipoVariable = new List<string>();
        double limit = 0;
        private int currentPage;
        private bool load;

        public static String FILTER1 = "?source=";
        public static String FILTER2 = "?$select";
        public static String FILTER3 = "?$order";
        public static String FILTER4 = "?$offset";
        public static String FILTER5 = "?$limit";
        public static String FILTER6 = "?$where";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addLink = "";
            filter.Hide();
            filters.Hide();
            comboBoxFilters.Hide();
            dataFilter.Hide();
            filterAdded.Hide();
            comboDatoS.Hide();
            addButton.Hide();
            currentPage = 1;
            MessageBox.Show("Por favor seleccione botón Buscar Base de Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Por favor seleccione filtro para departamento y variable", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<string> filtros = new List<string>();
                filtros.Add("Departamento");
                filtros.Add("Variable");
                filtros.Add("Fecha");

                for (int i = 0; i < filtros.Count; i++)
                {
                    comboBoxFilters.Items.Add(filtros[i]);
                }

                urlText.Enabled = false;
                codeData.Enabled = false;
                Console.WriteLine("Succesfull");
                filter.Show();
                filters.Show();
                comboDatoS.Show();
                comboBoxFilters.Show();
                dataFilter.Show();
                filterAdded.Show();
                addButton.Show();
                searchButton.Hide();
                map.Enabled = true;
                prediction.Enabled = true;
            }
            catch (ArgumentNullException ea) {
                Console.WriteLine("Something its wrong");
            }


        }



        private void searchData(object sender, EventArgs e)
        {
            currentPage = 1;
            label3.Text = "Page: " + currentPage;
            nextButton.Enabled = true;
            beforeButton.Enabled = true;

            dt = new DataTable();
            
            List<string> filtros = new List<string>();
            filtros.Add("Municipio");
            filtros.Add("Concentración");
            filtros.Add("Fecha");
            filtros.Add("Latitud");
            filtros.Add("Longitud");

            for (int i = 0; i < filtros.Count; i++)
            {
                dt.Columns.Add(new DataColumn(filtros[i], typeof(String)));
            }

            readInfo(urlText.Text);
            dataGridView.DataSource = dt;
            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[2].Visible = true;
            dataGridView.Columns[3].Visible = true;
            dataGridView.Columns[4].Visible = true;
        }


        public void readInfo(String bdId)
        {
            string result = "";

            try
            {
                int i;
                int j = 5000;

                if (limit > 5000)
                {
                    if (currentPage == 1)
                    {
                        i = 1;
                
                    }
                    else if (currentPage == 2)
                    {
                        i = 5001;
                        
                    }
                    else if (currentPage == 3)
                    {
                        i = 10001;
                       
                    }
                    else if (currentPage == 4)
                    {
                        i = 15001;
                      
                    }
                    else if (currentPage == 5)
                    {
                        i = 20001;
                     
                    }
                    else if (currentPage == 6)
                    {
                        i = 25001;
                     
                    }
                    else if (currentPage == 7)
                    {
                        i = 30001;
                     
                    }
                    else
                    {
                        i = 35001;
                       
                    }
                }
                else
                {
                    i = 1;
                    j = 5000;
                }

                // + "&$offset = "+i

                var url = "https://www.datos.gov.co/resource/" + bdId + ".json?" + addLink + "&$limit=" + j + "&$offset=" + i;
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;

                        while ((line = reader.ReadLine()) != null)
                        {
                            String[] args = line.Split(',');

                            String[] meh = args[13].Split(':');
                            String[] meh2 = meh[1].Split('"');

                            String[] la = args[5].Split(':');
                            String[] la2 = la[1].Split('"');

                            String[] lo = args[6].Split(':');
                            String[] lo2 = lo[1].Split('"');

                            String[] de = args[6].Split(':');
                            String[] de2 = de[1].Split('"');

                            String[] f = args[1].Split(':');
                            String[] f2 = f[1].Split('"');

                            String[] v = args[15].Split(':');
                            String[] v2 = v[1].Split('"');

                            String[] mu1 = args[10].Split(':');
                            String[] municipio = mu1[1].Split('"');

                            dt.Rows.Add("" + municipio[1], "" + v2[1], "" + f2[1], "" + la2[1], "" + lo2[1]);

                            if (meh2[1].Equals("PM10") || meh2[1].Equals("PM2.5"))
                            {
                            CultureInfo culture = new CultureInfo("en-US");
                            latitudes.Add(Convert.ToDouble(la2[1], culture));
                            longitudes.Add(Convert.ToDouble(lo2[1], culture));
                            departamentos.Add(de2[1]);
                            tipoVariable.Add(meh2[1]);
                            fechas.Add(f2[1]);

                            if (fechasNumbers.Count == 0)
                            {
                                String[] fechaSinHora = f2[1].Split(' ');
                                fechaSinHora = fechaSinHora[0].Split('/');
                                double dias = (Convert.ToDouble(fechaSinHora[0], culture) / 360);
                                double meses = (Convert.ToDouble(fechaSinHora[1], culture) / 30);
                                double años = (Convert.ToDouble(fechaSinHora[2], culture));
                                fechasNumbers.Add(dias + meses + años);
                            }
                            else 
                            {
                                fechasNumbers.Add(fechasNumbers[fechasNumbers.Count-1] + 0.03);
                            }

                            values.Add(Convert.ToDouble(v2[1], culture));
                        }
                            else
                            {
                                Console.WriteLine("F");
                            }
                        

                        count++;
                    }
                    Console.WriteLine(count);
                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException e)
            {
                result = string.Format("F", e);
                Console.WriteLine(result);
                MessageBox.Show("Por favor seleccione filtro para departamento y variable", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            String filtroSeleccionado = comboBoxFilters.Text.ToLower();
            String tipoSeleccionado = comboDatoS.Text.ToUpper();
           
            if (comboBoxFilters.Text.Equals("Departamento"))
            {
                limit = limitForPages(tipoSeleccionado);
                Console.WriteLine(limitForPages(tipoSeleccionado));
              
            } 

            if (!addLink.Equals(""))
            {
                addLink = addLink + " AND " + filtroSeleccionado + "= '" + tipoSeleccionado + "'" ;
               
            }
            else
            {
                addLink = "$where=" + filtroSeleccionado + "= '" + tipoSeleccionado + "'";
             
            }


            if (!filters.Text.Equals("Sin filtros"))
            {
                filters.Text = filters.Text + "\n" + comboBoxFilters.Text + ": " + comboDatoS.Text;
            }
            else
            {
                filters.Text = comboBoxFilters.Text + ": " + comboDatoS.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

              filters.Text = "Sin filtros";
              dataGridView.DataSource = "";


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prediction_Click(object sender, EventArgs e)
        {
            linearRegression(fechasNumbers, values, out rsquared, out yintercept, out slope);
            linearAplication(yintercept, slope);
            Form2 predictions = new Form2();
            predictions.graficarPredicciones(valuesPrediction, fechasNumbers);
            predictions.Show();
        }

        private void linearRegression(List<Double> xVals, List<Double> yVals,
                                        out double rsquared, out double yintercept,
                                        out double slope)
        {
            //Debug.Assert(xVals.Length == yVals.Length);
            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double ssX = 0;
            double ssY = 0;
            double sumCodeviates = 0;
            double sCo = 0;
            double count = 0;

            for (int ctr = 0; ctr < xVals.Count; ctr++)
            {
                double x = xVals[ctr];
                double y = yVals[ctr];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
                count++;
            }
            ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            ssY = sumOfYSq - ((sumOfY * sumOfY) / count);
            double RNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            double RDenom = (count * sumOfXSq - (sumOfX * sumOfX))
             * (count * sumOfYSq - (sumOfY * sumOfY));
            sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            double meanX = sumOfX / count;
            double meanY = sumOfY / count;
            double dblR = RNumerator / Math.Sqrt(RDenom);
            rsquared = dblR * dblR;
            yintercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;
        }

        private void linearAplication(double yintercept, double slope)
        {
            List<Double> valuesCalculated = new List<double>();
            for (int i = 0; i < fechasNumbers.Count; i++)
            {
                valuesCalculated.Add((fechasNumbers[i] * slope) + yintercept);
            }
            valuesPrediction = valuesCalculated;
        }

      

        private void map_Click(object sender, EventArgs e)
        {
            map map = new map();
            map.getData(fechas,tipoVariable,latitudes,longitudes,departamentos,values);
            map.Show();
            MessageBox.Show("Por favor escriba desde teclado el departamento por buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDatoS.Items.Clear();

            if (comboBoxFilters.Text.Equals("Departamento"))
            {
                List<String> departamentos = new List<String>();
                departamentos.Add("Antioquia");
                departamentos.Add("Arauca");
                departamentos.Add("Atlántico");
                departamentos.Add("Bolívar");
                departamentos.Add("Boyacá");
                departamentos.Add("Caldas");
                departamentos.Add("Casanare");
                departamentos.Add("Cauca");
                departamentos.Add("Cesar");
                departamentos.Add("Chocó");
                departamentos.Add("Córdoba");
                departamentos.Add("Cundinamarca");
                departamentos.Add("Huila");
                departamentos.Add("La Guajira");
                departamentos.Add("Magdalena");
                departamentos.Add("Meta");
                departamentos.Add("Nariño");
                departamentos.Add("Norte de Santander");
                departamentos.Add("Quindío");
                departamentos.Add("Risaralda");
                departamentos.Add("Santander");
                departamentos.Add("Tolima");
                departamentos.Add("Valle del Cauca");

                for (int i = 0; i < departamentos.Count; i++)
                {
                    comboDatoS.Items.Add(departamentos[i]);
                }

                comboDatoS.Show();
            } else if (comboBoxFilters.Text.Equals("Variable"))
            {
                
                comboDatoS.Items.Add("PM10");
                comboDatoS.Items.Add("PM2.5");

                comboDatoS.Show();

            } else
            {
                for (int i = 1; i < 8; i++)
                {
                    comboDatoS.Items.Add("201"+i);
                }

                comboDatoS.Show();
            }

        }

        public double limitForPages(String seleccionado)
        {
            double limit = 0;

            try
            {
                
                
                var url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?$select=departamento,count(departamento)&$group=departamento&$where=variable%20in%20(%27PM10%27,%27PM2.5%27)";
                var client = new WebClient();
                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        String[] args = line.Split(',');
                        String[] args2 = args[1].Split(':');
                        String[] departamento = args2[1].Split('"');
                        String[] args4 = args[2].Split(':');
                        String[] cantidad = args4[1].Split('"');

                        count++;

                        if (departamento[1].Equals(seleccionado))
                        {
                            limit = Convert.ToDouble(cantidad[1]);
                          
                        }

                
                    }

                    return limit;

                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException e)
            {
               string result = string.Format("F", e);
                
            }

            return limit;

        }

        private void comboDatoS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < 8 && load)
            {
                currentPage++;
                label3.Text = "Page: " + currentPage;
                readInfo(urlText.Text);
            }

        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1 && load)
            {
                currentPage--;
                label3.Text = "Page: " + currentPage;
                readInfo(urlText.Text);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

      
    }
