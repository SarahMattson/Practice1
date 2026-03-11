using System.CodeDom;

namespace Practice1;

public partial class Form2 : Form
{
    public Pet CurrentPet;

    public Form2(Pet inPet)
    {
        InitializeComponent();
        CurrentPet = inPet;
    }
    private void Form2_Load(object sender, EventArgs e)
    {
        txtName.Text = CurrentPet.Name;
        txtAge.Text = CurrentPet.Age.ToString();
        txtType.Text = CurrentPet.Type;

        lblTtitle.Text = CurrentPet.Type;
        lblSpeak.Text = CurrentPet.Speak();
        
        if(CurrentPet is Dog dog)
        {
            lblLoyalty.Text = dog.Loyalty.ToString();
        }
    }
}
