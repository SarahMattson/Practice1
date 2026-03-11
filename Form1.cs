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
            Pet petty;

            if (radCat.Checked)
            {
                petty = new cat();
            }
            else if (radDog.Checked)
            {
                petty = new Dog();
            }
            else if (radBird.Checked)
            {
                petty = new Bird();
            }
            else
            {
                petty = new cat();
            }

            if (txtName.Text != "")
            {
                petty.Name = txtName.Text;
                petty.Age = (int)nudAge.Value;
                petty.Type = petty.GetType().ToString().Split(".")[1]; // this is changing the class NAME to a STRING

            }
            else
            {
                return; // loser you did it wrong learn how to use computers you stupid fuck
            }

            pets.Add(petty);
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

        private void lstPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chosenIndex = lstPet.SelectedIndex;
            Pet chosenPet = pets[chosenIndex];
            Form2 formName = new Form2(chosenPet);
            formName.ShowDialog();
            UpdatePetList();
        }

        private void btnAddRandomAnimal_Click(object sender, EventArgs e)
        {
            Pet randomPet = PetFactory.GetRandomAnimal();
            pets.Add(randomPet);
            UpdatePetList();
        }
    }
}
