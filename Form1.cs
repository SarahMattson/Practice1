namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pet> pets = new List<Pet>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string radType = "?";
            if (radCat.Checked)
            {
                radType = "Cat";
            }
            else if (radDog.Checked)
            {
                radType = "Dog";
            }
            else if (radBird.Checked)
            {
                radType = "Bird";
            }

            Pet pet;

            if (txtName.Text == "")
            {
                pet = new Pet("Spot", (int)nudAge.Value + 1, "Dog");
            }
            else
            {
                pet = new Pet(txtName.Text, (int)nudAge.Value, radType);
            }

            pets.Add(pet);
            UpdatePetList();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            txtName.Focus();
            txtName.Text = "";
            nudAge.Value = 3;
            radCat.Checked = true;
            lstPet.Items.Clear();
        }

        public void UpdatePetList()
        {
            ResetForm();

            foreach (Pet pet in pets)
            {
                lstPet.Items.Add(pet.DisplayPet());
            }
        }
    }
}
