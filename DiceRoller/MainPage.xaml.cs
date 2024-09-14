namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void RandomButton_Clicked(object sender, EventArgs e)
    {
        // int numSelecionado = Convert.ToInt32(SidesPicker.SelectedItem.ToString()); //Associa a opção do menu a uma variável
        // int n1 = new Random().Next(1,numSelecionado + 1); // Realiza o sorteio de um número com base na variável
        // ResultLabel.Text = n1.ToString(); //Exibe o resultado na tela

        int qtdDados = int.Parse(DadosEntry.Text);
        int total = 0;
        int n1 = 0;
 
        for (int i = 0; i < qtdDados; i++)
        {
            int ladoSelecionado = Convert.ToInt32(LadosPicker.SelectedItem.ToString());
            int modificador = Convert.ToInt32(ModifyPicker.SelectedItem.ToString());
            n1 = new Random().Next(1, ladoSelecionado + 1) + modificador;
            total = n1 + total;
            DadosLabel.Text += " " + n1.ToString();
        }
        ResultLabel.Text = "O total foi:" + total.ToString();
    }
}