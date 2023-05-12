using System.Collections.ObjectModel;
using System.Globalization;

namespace FinalSemesterProject
{
    public partial class Form1 : Form
    {
        public static string ValueForTextAddressOutput = String.Empty;
        public static string ValueForTextJobQuote = String.Empty;

        public Form1()
        {
            InitializeComponent();


            List<string> states = new List<string>();
            states.Add("AL");
            states.Add("NC");
            states.Add("TN");
            states.Add("SC");
            states.Add("GA");
            comboState.Items.AddRange(states.ToArray());
            comboState.SelectedIndex = comboState.Items.IndexOf("TN");

            TxtLaborCharge.Text = "30.00";
            
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Floor and Carpet \n\n Version 1.0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = getMaterialData();
            DgMaterials.DataSource = bindingSource1;
            RdoProfessional.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (!string.IsNullOrEmpty(TxtName.Text))
            {
                customer.Fullname = TxtName.Text;
                customer.Address = TxtAddress.Text;
                customer.AddressLine2 = TxtAddressLine2.Text;
                customer.City = TxtCity.Text;
                customer.State = comboState.SelectedItem.ToString();
                customer.Zip = TxtZip.Text;
            }
            txtOutput.Text = customer.ToStringFormatted();
            ValueForTextAddressOutput = customer.ToStringFormatted();

        }

        private ObservableCollection<Material> getMaterialData()
        {
            ObservableCollection<Material> floorList = new ObservableCollection<Material>();
            floorList.Add(new Material("Cherry", "Hardwood", 8.00m));
            floorList.Add(new Material("Oak", "Hardwood", 9.75m));
            floorList.Add(new Material("Walnut", "Hardwood", 15.75m));
            floorList.Add(new Material("Bamboo", "Bamboo", 7.75m));
            floorList.Add(new Material("Pine Laminate", "Laminate", 7.00m));
            floorList.Add(new Material("Oak Laminate", "Laminate", 7.00m));
            floorList.Add(new Material("Cherry Laminate", "Laminate", 7.00m));
            floorList.Add(new Material("Linoleum", "Linoleum", 6.00m));
            floorList.Add(new Material("Glazed Ceramic", "Tile", 6.00m));
            floorList.Add(new Material("Quarry Tile", "Tile", 10.00m));
            floorList.Add(new Material("Porcelain Tile", "Tile", 30.00m));
            floorList.Add(new Material("Terracotta Tile", "Tile", 25.00m));
            floorList.Add(new Material("Wool Carpet", "Carpet", 6.00m));
            floorList.Add(new Material("Nylon Carpet", "Carpet", 6.00m));
            floorList.Add(new Material("Acryllic Carpet", "Carpet", 6.00m));
            floorList.Add(new Material("Polyester Carpet", "Carpet", 6.00m));
            floorList.Add(new Material("Travertine", "Stone", 22.00m));
            floorList.Add(new Material("Marble", "Stone", 50.00m));

            return floorList;
        }

        private void OpenJobQuote_Click(object sender, EventArgs e)
        {
            ValueForTextAddressOutput = txtOutput.Text;
            JobQuote q = new JobQuote();
            q.Show();
        }

        private void DgMaterials_SelectionChanged(object sender, EventArgs e)
        {
            Material ft = (Material)DgMaterials.CurrentRow.DataBoundItem;
            TxtMaterialDesc.Text = ft.Desc;
            TxtMaterialName.Text = ft.Name;
            TxtMaterialPrice.Text = ft.Price.ToString();
            UpdateCalculation();
        }

        private void UpdateCalculation()
        {
            decimal installationCost = 0.00m;
            if(!Decimal.TryParse(TxtMaterialCost.Text, out decimal defaultMaterialPrice))
            {
                defaultMaterialPrice = 1.00m;
            }

            Material buffer = new Material(
                TxtMaterialName.Text,
                TxtMaterialDesc.Text,
                defaultMaterialPrice);

            txtJobOutput.Text = String.Empty;
            if(!double.TryParse(TxtLength.Text, out double length))
            {
                TxtLength.Text = 1.0.ToString();
                length = 1.0;
            }
            buffer.Length = length;

            if(!double.TryParse(TxtWidth.Text, out double width))
            {
                TxtWidth.Text = 1.0.ToString();
                width = 1.0;
            }
            buffer.Width = width;

            if (RdoProfessional.Checked)
            {
                if(!decimal.TryParse(TxtLaborCharge.Text, out installationCost))
                {
                    installationCost = 30.00m;
                }
                
            }
            else
            {
                installationCost = 0.00m;
            }

            buffer.Labor = installationCost * (decimal)buffer.AreaSqYards;
            TxtSqFt01.Text = buffer.Area.ToString();
            TxtSqFt02.Text = buffer.AreaSqYards.ToString();

            TxtMaterialCost.Text = String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.GetCost);
            TxtEstimateTotal.Text = String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.TotalCost);
            TxtLaborCost.Text = String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.Labor);
            txtJobOutput.Text = buffer.ToStringDetail();
            ValueForTextJobQuote = txtJobOutput.Text;



        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            UpdateCalculation();
        }

        private void RdoProfessional_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Radio Clicked");
            UpdateCalculation();
        }
    }
}